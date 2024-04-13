using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        DatabaseHelper connect = new DatabaseHelper();
        public Form1()
        {
            InitializeComponent();
        }

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            dataGridView1.Columns.Add("idUtilizador", "ID Utilizador");
            dataGridView1.Columns.Add("email", "E-mail");
            dataGridView1.Columns.Add("userName", " UserName");
            dataGridView1.Columns.Add("nivelAcesso", "Tipo de Acesso");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            connect.PreencherDataGridView1(ref dataGridView1);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }*/
    }
}
