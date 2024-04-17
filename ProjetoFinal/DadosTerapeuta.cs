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
    public partial class DadosTerapeuta : Form
    {
        Connections ligacao = new Connections();
        public DadosTerapeuta()
        {
            InitializeComponent();
        }

        private void DadosTerapeuta_Load(object sender, EventArgs e)
        {
            ObterDados();

            if (txtNomeTerapeuta.Text.Length == 0)
            {
                MessageBox.Show("Por favor, preencha os seus dados pessoais.");
                btnAtualizarDadosPessoais.Text = "Inserir Dados Pessoais";
                txtNomeTerapeuta.Focus();
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
                    SELECT nome, especializacao, telefone, apresentacao, email, userName, password FROM utilizadores
	                    LEFT JOIN terapeutas ON utilizadores.idUtilizador = terapeutas.idUtilizador
                            WHERE utilizadores.idUtilizador = {idUtilizador}";

                SQLiteCommand cmd = new SQLiteCommand(queryObterDados, ligacao.OpenConnection());
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    txtNomeTerapeuta.Text = dataReader[0].ToString();
                    cbEspecialidade.Text = dataReader[1].ToString();
                    mtbContacto.Text = dataReader[2].ToString();
                    rtxtApresentacao.Text = dataReader[3].ToString();
                    txtEmail.Text = dataReader[4].ToString();
                    txtUserName.Text = dataReader[5].ToString();
                    txtPassword.Text = dataReader[6].ToString();
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

        private void InserirDadosPessoais()
        {
            try
            {
                int idUtilizador;
                idUtilizador = ((FormInicial)this.MdiParent).atualLogin;


                string queryInserirDados = $@"
                INSERT INTO terapeutas (idUtilizador, nome, especializacao, telefone, apresentacao) VALUES
                    ({idUtilizador},'{txtNomeTerapeuta.Text}', '{cbEspecialidade.Text}','{mtbContacto.Text}', '{rtxtApresentacao.Text}');";

                SQLiteCommand cmd = new SQLiteCommand(queryInserirDados, ligacao.OpenConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Inseridos com sucesso.");
                btnAtualizarDadosPessoais.Text = "Atualizar Dados Pessoais";
                groupBox2.Enabled = true;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool VerificarDadosConta()
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

        private void btnAtualizarDadosPessoais_Click(object sender, EventArgs e)
        {

            if (groupBox2.Enabled == false)
            {

                InserirDadosPessoais();
            }

            else
            {

                AtualizarDadosPessoais();
            }
        }

        private void AtualizarDadosPessoais()
        {
            try
            {
                int idUtilizador;
                idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

                string queryAtualizarDadosPessoais = $@"
                UPDATE terapeutas SET 
                    nome = '{txtNomeTerapeuta.Text}',
                    especializacao = '{cbEspecialidade.Text}',
                    telefone = '{mtbContacto}'
                    apresentacao = '{rtxtApresentacao}'
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

        private void btnAtualizarDadosConta_Click(object sender, EventArgs e)
        {
            VerificarDadosConta();
            AtualizarDadosConta();
        }
    }
}
