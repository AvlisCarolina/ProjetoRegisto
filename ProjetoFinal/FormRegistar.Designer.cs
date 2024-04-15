namespace ProjetoFinal
{
    partial class FormRegistar
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
            this.label2 = new System.Windows.Forms.Label();
            this.gbDadosConta = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoAcesso = new System.Windows.Forms.ComboBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gbDadosConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Conta:";
            // 
            // gbDadosConta
            // 
            this.gbDadosConta.Controls.Add(this.txtPassword);
            this.gbDadosConta.Controls.Add(this.txtUserName);
            this.gbDadosConta.Controls.Add(this.txtEmail);
            this.gbDadosConta.Controls.Add(this.label5);
            this.gbDadosConta.Controls.Add(this.label4);
            this.gbDadosConta.Controls.Add(this.label3);
            this.gbDadosConta.Controls.Add(this.cbTipoAcesso);
            this.gbDadosConta.Controls.Add(this.label2);
            this.gbDadosConta.Location = new System.Drawing.Point(17, 16);
            this.gbDadosConta.Margin = new System.Windows.Forms.Padding(4);
            this.gbDadosConta.Name = "gbDadosConta";
            this.gbDadosConta.Padding = new System.Windows.Forms.Padding(4);
            this.gbDadosConta.Size = new System.Drawing.Size(591, 269);
            this.gbDadosConta.TabIndex = 1;
            this.gbDadosConta.TabStop = false;
            this.gbDadosConta.Text = "Insira os Dados de Conta";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 214);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(372, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(151, 156);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(372, 22);
            this.txtUserName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 102);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome de Utilizador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // cbTipoAcesso
            // 
            this.cbTipoAcesso.FormattingEnabled = true;
            this.cbTipoAcesso.Items.AddRange(new object[] {
            "Paciente",
            "Terapeuta"});
            this.cbTipoAcesso.Location = new System.Drawing.Point(151, 41);
            this.cbTipoAcesso.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoAcesso.Name = "cbTipoAcesso";
            this.cbTipoAcesso.Size = new System.Drawing.Size(372, 24);
            this.cbTipoAcesso.TabIndex = 2;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(231, 310);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(176, 28);
            this.btnRegistar.TabIndex = 2;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(254, 346);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(127, 28);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar ao Início";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormRegistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 396);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.gbDadosConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registar";
            this.Load += new System.EventHandler(this.FormRegistar_Load);
            this.gbDadosConta.ResumeLayout(false);
            this.gbDadosConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDadosConta;
        private System.Windows.Forms.ComboBox cbTipoAcesso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnVoltar;
    }
}