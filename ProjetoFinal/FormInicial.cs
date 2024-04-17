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
        public int atualLogin;
 
        DadosPaciente formDadosPaciente = new DadosPaciente();
        RegistoCrise formRegistoCrise = new RegistoCrise();
        RegistoDiario formRegistoDiario = new RegistoDiario();
        VerRegistosPaciente formVerRegistosPaciente = new VerRegistosPaciente();
        informacaoTerapeuta formInformacaoTerapeuta = new informacaoTerapeuta();
       

        DadosTerapeuta formDadosTerapeuta = new DadosTerapeuta();
        InformacaoPacientes formInformacaoPacientes = new InformacaoPacientes();
        VerRegistosTerapeuta formVerRegistosTerapeuta = new VerRegistosTerapeuta();

        FormEntrar formIniciarSessao;
        FormRegistar formRegistar = new FormRegistar();

        
        public FormInicial()
        {
            
            InitializeComponent();
            formIniciarSessao = new FormEntrar(this);
            eliminarContaToolStripMenuItem.Visible = false;
            eliminarContaToolStripMenuItem1.Visible = false;
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            
            pacienteToolStripMenuItem.Visible = false;
            terapeutaToolStripMenuItem.Visible = false;
            terminarSessãoToolStripMenuItem.Visible = false;

            //Fazer dispose do form existente quando um outro é aberto
        }

        private void tsmEntrar_Click(object sender, EventArgs e)
        {
            if (formIniciarSessao.IsDisposed)
            {
                formIniciarSessao = new FormEntrar(this);
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

        private void novoRegistoDiárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formRegistoDiario.IsDisposed)
            {
                formRegistoDiario = new RegistoDiario();
            }
            formRegistoDiario.MdiParent = this;
            formRegistoDiario.StartPosition = FormStartPosition.CenterScreen;
            //formRegistoDiario.WindowState = FormWindowState.Maximized;
            formRegistoDiario.MinimizeBox = false;
            formRegistoDiario.MaximizeBox = false;

            formRegistoDiario.Show();
            formRegistoDiario.Activate();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formVerRegistosPaciente.IsDisposed)
            {
                formVerRegistosPaciente = new VerRegistosPaciente();
            }
            formVerRegistosPaciente.MdiParent = this;
            formVerRegistosPaciente.StartPosition = FormStartPosition.CenterScreen;
            //formVerRegistosPaciente.WindowState = FormWindowState.Maximized;
            formVerRegistosPaciente.MinimizeBox = false;
            formVerRegistosPaciente.MaximizeBox = false;

            formVerRegistosPaciente.Show();
            formVerRegistosPaciente.Activate();

        }

        private void informacaoTerapeutaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formInformacaoTerapeuta.IsDisposed)
            {
                formInformacaoTerapeuta = new informacaoTerapeuta();
            }
            formInformacaoTerapeuta.MdiParent = this;
            formInformacaoTerapeuta.StartPosition = FormStartPosition.CenterScreen;
            //formInformacaoTerapeuta.WindowState = FormWindowState.Maximized;
            formInformacaoTerapeuta.MinimizeBox = false;
            formInformacaoTerapeuta.MaximizeBox = false;

            formInformacaoTerapeuta.Show();
            formInformacaoTerapeuta.Activate();

        }

        private void dadosPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInformacaoPacientes.IsDisposed)
            {
                formInformacaoPacientes = new InformacaoPacientes();
            }
            formInformacaoPacientes.MdiParent = this;
            formInformacaoPacientes.StartPosition = FormStartPosition.CenterScreen;
            //formInformacaoPacientes.WindowState = FormWindowState.Maximized;
            formInformacaoPacientes.MinimizeBox = false;
            formInformacaoPacientes.MaximizeBox = false;

            formInformacaoPacientes.Show();
            formInformacaoPacientes.Activate();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formVerRegistosTerapeuta.IsDisposed)
            {
                formVerRegistosTerapeuta = new VerRegistosTerapeuta();
            }
            formVerRegistosTerapeuta.MdiParent = this;
            formVerRegistosTerapeuta.StartPosition = FormStartPosition.CenterScreen;
            //formVerRegistosTerapeuta.WindowState = FormWindowState.Maximized;
            formVerRegistosTerapeuta.MinimizeBox = false;
            formVerRegistosTerapeuta.MaximizeBox = false;

            formVerRegistosTerapeuta.Show();
            formVerRegistosTerapeuta.Activate();
        }

        public void Perfil(string perfil,string acesso, int idUtilizador)
        {
            atualLogin = idUtilizador;

            toolStripMenuItem1.Text = perfil;
            tsmEntrar.Visible = false;
            tsmRegistar.Visible = false;
            terminarSessãoToolStripMenuItem.Visible = true;

            if (acesso == "Terapeuta")
            {
                terapeutaToolStripMenuItem.Visible = true;
                pacienteToolStripMenuItem.Visible = false;
            }

            else if (acesso == "Paciente")
            {
                pacienteToolStripMenuItem.Visible = true;
                terapeutaToolStripMenuItem.Visible = false;
            }
            else
            {
                terapeutaToolStripMenuItem.Visible = true;
                pacienteToolStripMenuItem.Visible = true;
            }
        }
        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = "LogIn/SingUp";
            tsmEntrar.Visible = true;
            tsmRegistar.Visible = true;
            terminarSessãoToolStripMenuItem.Visible = false;
            pacienteToolStripMenuItem.Visible = false;
            terapeutaToolStripMenuItem.Visible = false;

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void reiniciarAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void fecharAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }
    }
}
