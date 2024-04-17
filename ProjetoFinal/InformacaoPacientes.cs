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
    public partial class InformacaoPacientes : Form
    {
        Connections ligacao = new Connections();
        public InformacaoPacientes()
        {
            InitializeComponent();
        }

        private void InformacaoPacientes_Load(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            dataGridView1.Columns.Add("idPaciente", "ID");
            dataGridView1.Columns.Add("nome", "Nome");
            dataGridView1.Columns.Add("email", "Email");

            TodosPacientes();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TodosPacientes()
        {
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

            string queryGeralPacientes = $@"
                SELECT idPaciente, nome, email FROM pacientes 
                   JOIN utilizadores ON pacientes.idUtilizador = utilizadores.idUtilizador
                        WHERE idTerapeuta = {idUtilizador}";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(queryGeralPacientes, ligacao.OpenConnection());
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                int idxLinha = 0;

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[idxLinha].Cells["idPaciente"].Value = dataReader[0].ToString();
                    dataGridView1.Rows[idxLinha].Cells["nome"].Value = dataReader[1].ToString();
                    dataGridView1.Rows[idxLinha].Cells["email"].Value = dataReader[2].ToString();

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
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

            string queryVisualizarDados = $@"
                SELECT nome, genero, dataNascimento, telefone, email FROM pacientes 
                   JOIN utilizadores ON pacientes.idUtilizador = utilizadores.idUtilizador
                        WHERE idTerapeuta = {idUtilizador};";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(queryVisualizarDados, ligacao.OpenConnection());
                SQLiteDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    txtNomePaciente.Text = dataReader[0].ToString();
                    txtGenero.Text = dataReader[1].ToString();
                    txtData.Text = dataReader[2].ToString();
                    mtbContacto.Text = dataReader[3].ToString();
                    txtEmail.Text = dataReader[4].ToString();

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
        }
    }
}
