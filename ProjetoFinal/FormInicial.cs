using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class FormInicial : Form
    {
        //instanciar forms
        DadosPaciente formDadosPaciente = new DadosPaciente();
        DadosTerapeuta formDadosTerapeuta = new DadosTerapeuta();
        FormEntrar formIniciarSessao = new FormEntrar();
        FormRegistar formRegistar = new FormRegistar();

        RegistoCrise formRegistoCrise = new RegistoCrise();
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            //pacienteToolStripMenuItem.Visible = false;
            //terapeutaToolStripMenuItem.Visible=false;
        }

        private void tsmEntrar_Click(object sender, EventArgs e)
        {
            //Fazer dispose dos forms

            if (formIniciarSessao.IsDisposed)
            {
                formIniciarSessao = new FormEntrar();
            }
            formIniciarSessao.MdiParent = this;
            formIniciarSessao.StartPosition = FormStartPosition.CenterScreen;
            formIniciarSessao.Show();
            formIniciarSessao.Activate();
        }

        private void tsmRegistar_Click(object sender, EventArgs e)
        {
            if (formRegistar.IsDisposed)
            {
                formRegistar = new FormRegistar();
            }
            formRegistar.MdiParent = this;
            formRegistar.StartPosition = FormStartPosition.CenterScreen;
            formRegistar.Show();
            formRegistar.Activate();
        }

        private void osMeusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDadosPaciente.IsDisposed)
            {
                formDadosPaciente = new DadosPaciente();
            }
            formDadosPaciente.MdiParent = this;
            formDadosPaciente.StartPosition = FormStartPosition.CenterScreen;
            //formDadosPaciente.WindowState = FormWindowState.Maximized;
            formDadosPaciente.MinimizeBox = false;
            formDadosPaciente.MaximizeBox = false;

            formDadosPaciente.Show();
            formDadosPaciente.Activate();
        }

        private void novoTerapeutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDadosTerapeuta.IsDisposed)
            {
                formDadosTerapeuta = new DadosTerapeuta();
            }
            formDadosTerapeuta.MdiParent = this;
            formDadosTerapeuta.StartPosition = FormStartPosition.CenterScreen;
            //formDadosTerapeuta.WindowState = FormWindowState.Maximized;
            formDadosTerapeuta.MinimizeBox = false;
            formDadosTerapeuta.MaximizeBox = false;

            formDadosTerapeuta.Show();
            formDadosTerapeuta.Activate();
        }

        private void adicionarRegistoCriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formRegistoCrise.IsDisposed)
            {
                formRegistoCrise = new RegistoCrise();
            }
            formRegistoCrise.MdiParent = this;
            formRegistoCrise.StartPosition = FormStartPosition.CenterScreen;
            //formRegistoCrise.WindowState = FormWindowState.Maximized;
            formRegistoCrise.MinimizeBox = false;
            formRegistoCrise.MaximizeBox = false;

            formRegistoCrise.Show();
            formRegistoCrise.Activate();
        }
    }
}
