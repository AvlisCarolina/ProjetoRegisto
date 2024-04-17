using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class RegistoDiario : Form
    {
        Connections ligacao = new Connections();

        public RegistoDiario()
        {
            InitializeComponent();
        }

        private void RegistoDiario_Load(object sender, EventArgs e)
        {
            ListarSensacoes();
            ListarSentimentos();
        }

        private bool ListarSensacoes()
        {
            clbSensacoes.Items.Clear();
            string sensacao, id;
            bool flag = false;

            string queryTipoSensacao = "SELECT * FROM sensacoes;";

            try
            {
                var conexao = ligacao.OpenConnection();

                SQLiteCommand cmd = new SQLiteCommand(queryTipoSensacao, conexao);
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = dataReader[0].ToString();
                    sensacao = dataReader[1].ToString();
                    flag = true;

                    clbSensacoes.Items.Add($"{id} - {sensacao}");
                }
                dataReader.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao iniciar conexão." + ex.Message);
            }
            finally
            {
                ligacao.CloseConnection();
            }
            return flag;
        }

        private bool ListarSentimentos()
        {
            clbSentimentos.Items.Clear();
            string sentimento, id;
            bool flag = false;

            string queryTipoSentimento = "SELECT * FROM sentimentos;";

            try
            {
                var conexao = ligacao.OpenConnection();

                SQLiteCommand cmd = new SQLiteCommand(queryTipoSentimento, conexao);
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = dataReader[0].ToString();
                    sentimento = dataReader[1].ToString();
                    flag = true;

                    clbSentimentos.Items.Add($"{id} - {sentimento}");
                }
                dataReader.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao iniciar conexão." + ex.Message);
            }
            finally
            {
                ligacao.CloseConnection();
            }
            return flag;
        }

        private void InserirDiario()
        {
            if (ValidarData(dateTimePicker1.Text))
            {
                string queryInserirDiario = $@"
                INSERT INTO diario 
                    (data, sono, alimentacao, atividadeFisica, convivioSocial, detalhes, crise, idPaciente) VALUES
                    ('{dateTimePicker1.Text}', '{cbSono.Text}','{cbAlimentacao.Text}', '{cbAtividadeFisica.Text}', '{cbConvivio.Text}', '{rtxtDetalhe.Text}', '{cbCrise.Text}', {SelectPaciente()});
                SELECT last_insert_rowid();";

                SQLiteCommand cmd = new SQLiteCommand(queryInserirDiario, ligacao.OpenConnection());
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {

                    int idDiario = int.Parse(dataReader[0].ToString());

                    foreach (string sensacao in clbSensacoes.CheckedItems)
                    {
                        int idSensacao = int.Parse(sensacao.Split(new Char[] { ' ' })[0]);
                        string queryInserirSensacoes = $@"
                        INSERT INTO DiarioListaSensacoes (idDiario, idSensacao) VALUES
                            ({idDiario},{idSensacao})";

                        SQLiteCommand cmd1 = new SQLiteCommand(queryInserirSensacoes, ligacao.OpenConnection());
                        cmd1.ExecuteNonQuery();

                    }

                    foreach (string sentimento in clbSentimentos.CheckedItems)
                    {
                        int idSentimento = int.Parse(sentimento.Split(new Char[] { ' ' })[0]);
                        string queryInserirSentimentos = $@"
                        INSERT INTO DiarioListaSentimentos (idDiario, idSentimento) VALUES
                            ({idDiario},{idSentimento})";

                        SQLiteCommand cmd1 = new SQLiteCommand(queryInserirSentimentos, ligacao.OpenConnection());
                        cmd1.ExecuteNonQuery();

                    }

                    MessageBox.Show("Registo diário efetuado com sucesso.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro na introdução do registo. Confirme se todos os campos estão devidamente preenchidos.");
                    dateTimePicker1.Focus();
                }

                ligacao.CloseConnection();
            }
            else
            {
                MessageBox.Show("Já existe um registo diário na data pretendida.");
            }
            
        }

        private int SelectPaciente()
        {
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

            string queryIdPaciente = $@"
                SELECT idPaciente FROM pacientes 
                WHERE pacientes.idUtilizador = {idUtilizador};";

            SQLiteCommand cmd = new SQLiteCommand(queryIdPaciente, ligacao.OpenConnection());
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                int idPaciente = int.Parse(dataReader[0].ToString());

                dataReader.Close();

                //ligacao.CloseConnection();
                return idPaciente;
            }
            ligacao.CloseConnection();
            return 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirDiario();
        }

        private bool ValidarData(string dataDiario)
        {
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

            string queryDataRegisto = $@"
                SELECT data FROM diario 
                    JOIN pacientes ON diario.idPaciente = pacientes.idPaciente
                    WHERE pacientes.idUtilizador = {idUtilizador}
                    AND diario.data = '{dataDiario}';";

            SQLiteCommand cmd = new SQLiteCommand(queryDataRegisto, ligacao.OpenConnection());
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                string dataRegisto = dataReader[0].ToString();
                dataReader.Close();

                //ligacao.CloseConnection();
                return false;
            }
            ligacao.CloseConnection();
            return true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
