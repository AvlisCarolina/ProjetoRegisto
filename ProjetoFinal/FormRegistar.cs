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
    public partial class FormRegistar : Form
    {
        Connections ligacao = new Connections();
        public FormRegistar()
        {
            InitializeComponent();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRegistar_Load(object sender, EventArgs e)
        {
            
            cbTipoAcesso.Focus();
            //btnRegistar.Enabled = false;
            
            DadosTipoConta();
        }

        private bool DadosTipoConta()
        {
            cbTipoAcesso.Items.Clear();
            string tipo, id;
            bool flag = false;

            string queryTipoConta = "SELECT * FROM acessos;";

            try
            {
                var conexao = ligacao.OpenConnection();

                SQLiteCommand cmd = new SQLiteCommand(queryTipoConta, conexao);
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = dataReader[0].ToString();
                    tipo = dataReader[1].ToString();
                    flag = true;

                    cbTipoAcesso.Items.Add($"{id} - {tipo}");
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

        private bool VerificarDados()
        {
            var conexao = ligacao.OpenConnection();

            if (cbTipoAcesso.Text.Length == 0 || txtEmail.Text.Length == 0 || txtUserName.Text.Length == 0) 
            {
                
                MessageBox.Show("Erro ao preencher campos.");
                cbTipoAcesso.Focus();
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
                    ligacao.CloseConnection();
                    return false;
                }
                ligacao.CloseConnection();
                return true;
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (VerificarDados())
            {
                string[] texto = cbTipoAcesso.Text.Split(new Char[] { '-' });
                string idAcesso = texto[0];

                if (RegistarNovoUser(idAcesso, txtEmail.Text, txtUserName.Text, txtPassword.Text))
                {
                    MessageBox.Show("Novo Utilizador Registado com sucesso. Faça iniciar sessão e atualize os seus dados pessoais.");
                                        
                    FormEntrar formIniciarSessao = new FormEntrar((FormInicial)this.MdiParent);
                 
                    formIniciarSessao.MdiParent = this.MdiParent;
                    formIniciarSessao.StartPosition = FormStartPosition.CenterScreen;
                    formIniciarSessao.Show();
                    formIniciarSessao.Activate();

                    Close();                   
                }
                else
                {
                    MessageBox.Show("Erro ao registar utilizador. Verifique se todos os campos estão devidamente preenchidos.");
                }
            }

        }

        private bool RegistarNovoUser (string idAcesso, string email, string userName, string password)
        {
            string queryNovoUser = $@"
                INSERT INTO utilizadores (email, userName, password, idAcesso) VALUES
                    ('{email}', '{userName}', '{password}', {idAcesso});";

            bool flag = true;

            try
            {
                var conexao = ligacao.OpenConnection();
                SQLiteCommand cmd = new SQLiteCommand(queryNovoUser, conexao);
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                ligacao.CloseConnection();
            }
            return flag;
        }
    }
}
