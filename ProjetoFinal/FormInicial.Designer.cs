namespace ProjetoFinal
{
    partial class FormInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osMeusDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osMeusRegistosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoRegistoDiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarRegistoCriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terapeutaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informacaoTerapeutaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarContaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.terapeutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoTerapeutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEntrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistar = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.suporteToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.terapeutaToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1101, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 28);
            this.inicioToolStripMenuItem.Text = "&Início";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarAppToolStripMenuItem,
            this.fecharAppToolStripMenuItem});
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(60, 28);
            this.suporteToolStripMenuItem.Text = "&Suporte";
            // 
            // reiniciarAppToolStripMenuItem
            // 
            this.reiniciarAppToolStripMenuItem.Name = "reiniciarAppToolStripMenuItem";
            this.reiniciarAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reiniciarAppToolStripMenuItem.Text = "&Reiniciar App";
            this.reiniciarAppToolStripMenuItem.Click += new System.EventHandler(this.reiniciarAppToolStripMenuItem_Click);
            // 
            // fecharAppToolStripMenuItem
            // 
            this.fecharAppToolStripMenuItem.Name = "fecharAppToolStripMenuItem";
            this.fecharAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharAppToolStripMenuItem.Text = "Fechar App";
            this.fecharAppToolStripMenuItem.Click += new System.EventHandler(this.fecharAppToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osMeusDadosToolStripMenuItem,
            this.osMeusRegistosToolStripMenuItem,
            this.terapeutaToolStripMenuItem1,
            this.eliminarContaToolStripMenuItem1});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.pacienteToolStripMenuItem.Text = "Área &Paciente";
            // 
            // osMeusDadosToolStripMenuItem
            // 
            this.osMeusDadosToolStripMenuItem.Name = "osMeusDadosToolStripMenuItem";
            this.osMeusDadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osMeusDadosToolStripMenuItem.Text = "&Os Meus Dados";
            this.osMeusDadosToolStripMenuItem.Click += new System.EventHandler(this.osMeusDadosToolStripMenuItem_Click);
            // 
            // osMeusRegistosToolStripMenuItem
            // 
            this.osMeusRegistosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem2,
            this.novoRegistoDiárioToolStripMenuItem,
            this.adicionarRegistoCriseToolStripMenuItem});
            this.osMeusRegistosToolStripMenuItem.Name = "osMeusRegistosToolStripMenuItem";
            this.osMeusRegistosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osMeusRegistosToolStripMenuItem.Text = "&Registos";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(201, 22);
            this.consultarToolStripMenuItem2.Text = "&Ver Registos";
            this.consultarToolStripMenuItem2.Click += new System.EventHandler(this.consultarToolStripMenuItem2_Click);
            // 
            // novoRegistoDiárioToolStripMenuItem
            // 
            this.novoRegistoDiárioToolStripMenuItem.Name = "novoRegistoDiárioToolStripMenuItem";
            this.novoRegistoDiárioToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.novoRegistoDiárioToolStripMenuItem.Text = "Adicionar Registo &Diário";
            this.novoRegistoDiárioToolStripMenuItem.Click += new System.EventHandler(this.novoRegistoDiárioToolStripMenuItem_Click);
            // 
            // adicionarRegistoCriseToolStripMenuItem
            // 
            this.adicionarRegistoCriseToolStripMenuItem.Name = "adicionarRegistoCriseToolStripMenuItem";
            this.adicionarRegistoCriseToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.adicionarRegistoCriseToolStripMenuItem.Text = "Adicionar Registo &Crise";
            this.adicionarRegistoCriseToolStripMenuItem.Click += new System.EventHandler(this.adicionarRegistoCriseToolStripMenuItem_Click);
            // 
            // terapeutaToolStripMenuItem1
            // 
            this.terapeutaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacaoTerapeutaToolStripMenuItem2});
            this.terapeutaToolStripMenuItem1.Name = "terapeutaToolStripMenuItem1";
            this.terapeutaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.terapeutaToolStripMenuItem1.Text = "&Terapeuta";
            // 
            // informacaoTerapeutaToolStripMenuItem2
            // 
            this.informacaoTerapeutaToolStripMenuItem2.Name = "informacaoTerapeutaToolStripMenuItem2";
            this.informacaoTerapeutaToolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.informacaoTerapeutaToolStripMenuItem2.Text = "&Informação Terapeuta";
            this.informacaoTerapeutaToolStripMenuItem2.Click += new System.EventHandler(this.informacaoTerapeutaToolStripMenuItem2_Click);
            // 
            // eliminarContaToolStripMenuItem1
            // 
            this.eliminarContaToolStripMenuItem1.Name = "eliminarContaToolStripMenuItem1";
            this.eliminarContaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eliminarContaToolStripMenuItem1.Text = "&Eliminar Conta";
            // 
            // terapeutaToolStripMenuItem
            // 
            this.terapeutaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoTerapeutaToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.eliminarContaToolStripMenuItem});
            this.terapeutaToolStripMenuItem.Name = "terapeutaToolStripMenuItem";
            this.terapeutaToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.terapeutaToolStripMenuItem.Text = "Área &Terapeuta";
            // 
            // novoTerapeutaToolStripMenuItem
            // 
            this.novoTerapeutaToolStripMenuItem.Name = "novoTerapeutaToolStripMenuItem";
            this.novoTerapeutaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoTerapeutaToolStripMenuItem.Text = "&Os Meus Dados";
            this.novoTerapeutaToolStripMenuItem.Click += new System.EventHandler(this.novoTerapeutaToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosPacientesToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pacientesToolStripMenuItem.Text = "&Pacientes";
            // 
            // dadosPacientesToolStripMenuItem
            // 
            this.dadosPacientesToolStripMenuItem.Name = "dadosPacientesToolStripMenuItem";
            this.dadosPacientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dadosPacientesToolStripMenuItem.Text = "&Dados";
            this.dadosPacientesToolStripMenuItem.Click += new System.EventHandler(this.dadosPacientesToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatóriosToolStripMenuItem.Text = "&Registos";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // eliminarContaToolStripMenuItem
            // 
            this.eliminarContaToolStripMenuItem.Name = "eliminarContaToolStripMenuItem";
            this.eliminarContaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarContaToolStripMenuItem.Text = "&Eliminar Conta";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEntrar,
            this.tsmRegistar,
            this.terminarSessãoToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::ProjetoFinal.Properties.Resources.Person;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.RightToLeftAutoMirrorImage = true;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 28);
            this.toolStripMenuItem1.Text = "LogIn/SingUp";
            // 
            // tsmEntrar
            // 
            this.tsmEntrar.Name = "tsmEntrar";
            this.tsmEntrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmEntrar.RightToLeftAutoMirrorImage = true;
            this.tsmEntrar.Size = new System.Drawing.Size(158, 22);
            this.tsmEntrar.Text = "&Iniciar Sessão";
            this.tsmEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsmEntrar.Click += new System.EventHandler(this.tsmEntrar_Click);
            // 
            // tsmRegistar
            // 
            this.tsmRegistar.AutoSize = false;
            this.tsmRegistar.Name = "tsmRegistar";
            this.tsmRegistar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmRegistar.RightToLeftAutoMirrorImage = true;
            this.tsmRegistar.Size = new System.Drawing.Size(180, 22);
            this.tsmRegistar.Text = "&Novo Utilizador";
            this.tsmRegistar.Click += new System.EventHandler(this.tsmRegistar_Click);
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.terminarSessãoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.terminarSessãoToolStripMenuItem.Text = "&Terminar Sessão";
            this.terminarSessãoToolStripMenuItem.Click += new System.EventHandler(this.terminarSessãoToolStripMenuItem_Click);
            // 
            // FormInicial
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProjetoFinal.Properties.Resources.backgroungImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 635);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Minha Terapia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terapeutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osMeusDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osMeusRegistosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem novoRegistoDiárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarRegistoCriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terapeutaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informacaoTerapeutaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarContaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoTerapeutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmEntrar;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistar;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharAppToolStripMenuItem;
    }
}