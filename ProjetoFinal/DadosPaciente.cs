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
    public partial class DadosPaciente : Form
    {
        Connections ligacao = new Connections();
        public DadosPaciente()
        {
            InitializeComponent();
        }

        private void DadosPaciente_Load(object sender, EventArgs e)
        {
            
            DadosTerapeuta();
            ObterDados();

            if (txtNomePaciente.Text.Length == 0 ) 
            {
                MessageBox.Show("Por favor, preencha os seus dados pessoais.");
                btnAtualizarDadosPessoais.Text = "Inserir Dados Pessoais";
                txtNomePaciente.Focus();
                groupBox2.Enabled = false;
            }
        }

        private void ObterDados()
        {
            try
            {
                int idUtilizador;
                idUtilizador = ((FormInicial)this.MdiParent).atualLogin;


                string queryObterDados = $@"
                SELECT pacientes.nome, genero, dataNascimento, pacientes.telefone, email, userName, password, terapeutas.nome FROM utilizadores
                    LEFT JOIN pacientes ON pacientes.idUtilizador = utilizadores.idUtilizador
                    LEFT JOIN terapeutas ON terapeutas.idTerapeuta = pacientes.idTerapeuta
                    WHERE utilizadores.idUtilizador = {idUtilizador}";

                SQLiteCommand cmd = new SQLiteCommand(queryObterDados, ligacao.OpenConnection());
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    txtNomePaciente.Text = dataReader[0].ToString();
                    cbGenero.Text = dataReader[1].ToString();
                    mtxtDataNascimento.Text = dataReader[2].ToString();
                    mtbContacto.Text = dataReader[3].ToString();
                    txtEmail.Text = dataReader[4].ToString();
                    txtUserName.Text = dataReader[5].ToString();
                    txtPassword.Text = dataReader[6].ToString();
                    cbTerapeuta.Text = dataReader[7].ToString();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                //Close();
            }
            finally
            {
                ligacao.CloseConnection();
            }
        }

        private void InserirDadosPessoais(string idTerapeuta)
        {
            try
            {
                int idUtilizador;
                idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

                
                string queryInserirDados = $@"
                INSERT INTO pacientes (idUtilizador,nome, genero, dataNascimento, telefone, idTerapeuta) VALUES
                    ({idUtilizador},'{txtNomePaciente.Text}', '{cbGenero.Text}', '{mtxtDataNascimento.Text}', '{mtbContacto.Text}', {idTerapeuta});"; //Mudar Terapeuta

                SQLiteCommand cmd = new SQLiteCommand(queryInserirDados, ligacao.OpenConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Inseridos com sucesso.");
                btnAtualizarDadosPessoais.Text = "Atualizar Dados Pessoais";
                groupBox2.Enabled = true;
                cbTerapeuta.Enabled = false;
                btnVoltar.Focus();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao introduzir os dados. " + ex.Message);
            }
            finally
            {
                ligacao.CloseConnection();
            }
        }

        private void btnAtualizarDadosPessoais_Click(object sender, EventArgs e)
        {
            if (groupBox2.Enabled == false) 
            {
                string[] texto = cbTerapeuta.Text.Split(new Char[] { '-' });
                string idTerapeuta = texto[0];

                InserirDadosPessoais(idTerapeuta);
            }

            else
            {

                AtualizarDadosPessoais();
            }
                
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarDadosPessoais()
        {
            try
            {
                int idUtilizador;
                idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

                string queryAtualizarDadosPessoais = $@"
                UPDATE pacientes SET 
                    nome = '{txtNomePaciente.Text}',
                    genero = '{cbGenero.Text}',
                    dataNascimento = '{mtxtDataNascimento.Text}',
                    telefone = '{mtbContacto}'
                        WHERE idUtilizador = {idUtilizador};";

                SQLiteCommand cmd = new SQLiteCommand(queryAtualizarDadosPessoais, ligacao.OpenConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados com sucesso.");
                btnAtualizarDadosPessoais.Enabled = false;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao atualizar os dados. " + ex.Message);
            }
            finally
            {
                ligacao.CloseConnection();
            }

        }

        private void AtualizarDadosConta()
        {
            try
            {
                int idUtilizador;
                idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

                string queryAtualizarDadosPessoais = $@"
                UPDATE utilizadores SET 
                    email = '{txtEmail.Text}',
                    userName = '{txtUserName.Text}',
                    password = '{txtPassword.Text}',
                        WHERE idUtilizador = {idUtilizador};";

                SQLiteCommand cmd = new SQLiteCommand(queryAtualizarDadosPessoais, ligacao.OpenConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados com sucesso.");
                btnAtualizarDadosConta.Enabled = false;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao atualizar os dados. " + ex.Message);
            }
            finally
            {
                ligacao.CloseConnection();
            }
        }

        private bool VerificarDados()
        {
            var conexao = ligacao.OpenConnection();

            if (txtEmail.Text.Length == 0 || txtUserName.Text.Length == 0)
            {

                MessageBox.Show("Erro ao preencher campos.");
                txtUserName.Focus();
                return false;
            }
            else
            {
                string queryVerificarDados = $@"
                    SELECT * FROM utilizadores WHERE 
                        email = '{txtEmail.Text}' OR userName = '{txtUserName.Text}'";

                SQLiteCommand cmd = new SQLiteCommand(queryVerificarDados, conexao);
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    MessageBox.Show("O email ou userName indicados já se encontram registados no sistema. Insira outros dados.");
                    txtEmail.Focus();
                    return false;
                }
                return true;
            }
        }

        private bool DadosTerapeuta()
        {
            cbTerapeuta.Items.Clear();
            string nome, id;
            bool flag = false;

            string queryTerapeuta = "SELECT * FROM terapeutas;";

            try
            {
                var conexao = ligacao.OpenConnection();

                SQLiteCommand cmd = new SQLiteCommand(queryTerapeuta, conexao);
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = dataReader[0].ToString();
                    nome = dataReader[1].ToString();
                    flag = true;

                    cbTerapeuta.Items.Add($"{id} - {nome}");
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

        private void btnAtualizarDadosConta_Click(object sender, EventArgs e)
        {
            if (VerificarDados())
            {
                AtualizarDadosConta();
            }
            
        }


        //Falta e Update
    }
}
