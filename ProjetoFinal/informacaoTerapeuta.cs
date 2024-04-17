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
    public partial class informacaoTerapeuta : Form
    {
        Connections ligacao = new Connections();
        public informacaoTerapeuta()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TerapeutaAtual()
        {
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

            string queryTerapeutaAtual = $@"
                SELECT terapeutas.nome, especializacao, utilizadores.email, terapeutas.telefone, apresentacao FROM terapeutas
	                JOIN utilizadores ON utilizadores.idUtilizador = terapeutas.idUtilizador
	                JOIN pacientes ON terapeutas.idTerapeuta = pacientes.idTerapeuta
		                WHERE pacientes.idUtilizador = {idUtilizador}";

            SQLiteCommand cmd = new SQLiteCommand(queryTerapeutaAtual, ligacao.OpenConnection());
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                txtNomeAtual.Text = dataReader[0].ToString();
                txtEspecialidade.Text = dataReader[1].ToString();
                txtEmailAtual.Text = dataReader[2].ToString();
                txtContacto.Text = dataReader[3].ToString();
                rtxtApresentacao.Text = dataReader[4].ToString();
            }
            dataReader.Close();
            
            
        }

        private void informacaoTerapeuta_Load(object sender, EventArgs e)
        {
            TerapeutaAtual();
            MostrarTerapeutas();
        }

        private bool MostrarTerapeutas()
        {
            cbTerapeuta.Items.Clear();
            string nome, id;
            bool flag = false;

            string queryTerapeuta = "SELECT * FROM terapeutas;";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(queryTerapeuta, ligacao.OpenConnection());
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                nome = "";

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

        private void cbTerapeuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] texto = cbTerapeuta.Text.Split(new Char[] { '-' });
            string idTerapeuta = texto[0];

            string queryTodosTerapeutas = $@"
                SELECT especializacao, utilizadores.email, terapeutas.telefone, apresentacao FROM terapeutas
	                JOIN utilizadores ON utilizadores.idUtilizador = terapeutas.idUtilizador
		                WHERE terapeutas.idTerapeuta = '{idTerapeuta}'";

            SQLiteCommand cmd1 = new SQLiteCommand(queryTodosTerapeutas, ligacao.OpenConnection());
            SQLiteDataReader dataReader1 = cmd1.ExecuteReader();

            if (dataReader1.Read())
            {
                txtEspecialidade1.Text = dataReader1[0].ToString();
                txtEmail1.Text = dataReader1[1].ToString();
                txtContacto1.Text = dataReader1[2].ToString();
                rtxtApresentacao1.Text = dataReader1[3].ToString();
            }
            dataReader1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] texto = cbTerapeuta.Text.Split(new Char[] { '-' });
            string idTerapeuta = texto[0];

            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer alterar para o terapeuta selecionado?", "Confirmação Alteração.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string queryMudarTerapeuta = $@"
                UPDATE pacientes SET idTerapeuta = {idTerapeuta}
	                WHERE pacientes.idUtilizador = {idUtilizador};";

                SQLiteCommand cmd = new SQLiteCommand(queryMudarTerapeuta, ligacao.OpenConnection());
                cmd.ExecuteNonQuery();

                TerapeutaAtual();
                MostrarTerapeutas();

            }
            else if (dialogResult == DialogResult.No)
            {
                txtNomeAtual.Focus();
            }
            Close();
        }
    }
}
