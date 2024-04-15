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
    public partial class RegistoCrise : Form
    {
        
        Connections ligacao = new Connections();
        public RegistoCrise()
        {
            InitializeComponent();
        }

        private void RegistoCrise_Load(object sender, EventArgs e)
        {
            ListarSensacoes();
            ListarSentimentos();
        }

        private bool ListarSensacoes()
        {
            clbSensacoes.Items.Clear();
            string sensacao,id;
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

        private void InserirCrise()
        {

            string queryInserirCrise = $@"
                INSERT INTO crises 
                    (dataHora, duracaoCrise, nivelAnsiedade, nivelDepressao, idPaciente, descricaoSituacao, pensamentosImagens) VALUES
                    ('{dateTimePicker1.Text} {mtxtHora.Text}', '{cbDuracao.Text}', '{cbAnsiedade.Text}', '{cbDepressao.Text}', {SelectPaciente()}, '{rtxtPensamentos.Text}', '{rtxtSituacao.Text}');
                SELECT last_insert_rowid();";

            SQLiteCommand cmd = new SQLiteCommand(queryInserirCrise, ligacao.OpenConnection());
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {

                int idCrise = int.Parse(dataReader[0].ToString());
               
                foreach (string sensacao in clbSensacoes.CheckedItems)
                {
                    int idSensacao = int.Parse(sensacao.Split(new Char[] { ' ' })[0]);
                    string queryInserirSensacoes = $@"
                        INSERT INTO criseListaSensacoes (idCrise, idSensacao) VALUES
                            ({idCrise},{idSensacao})";

                    SQLiteCommand cmd1 = new SQLiteCommand(queryInserirSensacoes, ligacao.OpenConnection());
                    cmd1.ExecuteNonQuery();

                }

                foreach (string sentimento in clbSentimentos.CheckedItems)
                {
                    int idSentimento = int.Parse(sentimento.Split(new Char[] { ' ' })[0]);
                    string queryInserirSentimentos = $@"
                        INSERT INTO criseListaSentimentos (idCrise, idSentimento) VALUES
                            ({idCrise},{idSentimento})";

                    SQLiteCommand cmd1 = new SQLiteCommand(queryInserirSentimentos, ligacao.OpenConnection());
                    cmd1.ExecuteNonQuery();

                }

                MessageBox.Show("Registo de crise efetuado com sucesso.");
                Close();
            }
            else
            {
                MessageBox.Show("Erro na introdução do registo. Confirme se todos os campos estão devidamente preenchidos.");
                dateTimePicker1.Focus();
            }

            ligacao.CloseConnection();  
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
            InserirCrise();
        }
    }
}
