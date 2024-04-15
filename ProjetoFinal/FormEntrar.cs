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
    public partial class FormEntrar : Form
    {
        Connections ligacao = new Connections();
        FormInicial formInicial;
        public FormEntrar(FormInicial formInicial)
        {
            this.formInicial = formInicial;
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEntrar_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private bool ValidarUser(ref string acesso, ref int idUtilizador) 
        {
            bool flag = false;           

            try
            {
                string queryValidarUser = $@"
                    SELECT acessos.nivelAcesso, utilizadores.userName, utilizadores.idUtilizador FROM utilizadores 
                        JOIN acessos ON acessos.idAcesso = utilizadores.idAcesso
                        WHERE utilizadores.userName = '{txtUserName.Text}' AND utilizadores.password = '{txtPass.Text}';";

                SQLiteCommand cmd = new SQLiteCommand(queryValidarUser, ligacao.OpenConnection());
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    acesso = dataReader[0].ToString(); 
                    idUtilizador = int.Parse(dataReader[2].ToString());
                    return true;
                }
                MessageBox.Show("Nome de utilizador ou password incorretos.");
                txtUserName.Focus();
                txtPass.Text = string.Empty;
                txtUserName.Text = string.Empty;

                return false;

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ligacao.CloseConnection();
            }
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acesso = string.Empty;
            int idUtilizador = 0;

            if (ValidarUser(ref acesso, ref idUtilizador))
            {
                formInicial.Perfil($"Bem Vindo(a) {txtUserName.Text}", acesso, idUtilizador);
                Close();
            }
        }
    }
}
