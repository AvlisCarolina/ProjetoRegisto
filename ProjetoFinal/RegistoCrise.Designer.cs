namespace ProjetoFinal
{
    partial class RegistoCrise
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbSensacoes = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtxtSituacao = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtPensamentos = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clbSentimentos = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDepressao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAnsiedade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDuracao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtHora = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbSensacoes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rtxtSituacao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rtxtPensamentos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.clbSentimentos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbDepressao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbAnsiedade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbDuracao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtxtHora);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 1073);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório de Crise";
            // 
            // clbSensacoes
            // 
            this.clbSensacoes.CheckOnClick = true;
            this.clbSensacoes.ColumnWidth = 185;
            this.clbSensacoes.FormattingEnabled = true;
            this.clbSensacoes.HorizontalScrollbar = true;
            this.clbSensacoes.Location = new System.Drawing.Point(36, 207);
            this.clbSensacoes.MultiColumn = true;
            this.clbSensacoes.Name = "clbSensacoes";
            this.clbSensacoes.Size = new System.Drawing.Size(707, 196);
            this.clbSensacoes.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 1021);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submeter Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxtSituacao
            // 
            this.rtxtSituacao.Location = new System.Drawing.Point(36, 848);
            this.rtxtSituacao.Name = "rtxtSituacao";
            this.rtxtSituacao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtSituacao.Size = new System.Drawing.Size(707, 147);
            this.rtxtSituacao.TabIndex = 16;
            this.rtxtSituacao.Text = "";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(35, 666);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descreva quaisquer pensamentos ou imagens que possa ter tido.";
            // 
            // rtxtPensamentos
            // 
            this.rtxtPensamentos.Location = new System.Drawing.Point(36, 685);
            this.rtxtPensamentos.Name = "rtxtPensamentos";
            this.rtxtPensamentos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtPensamentos.Size = new System.Drawing.Size(707, 114);
            this.rtxtPensamentos.TabIndex = 14;
            this.rtxtPensamentos.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Selecione todos os sentimentos experienciados.";
            // 
            // clbSentimentos
            // 
            this.clbSentimentos.CheckOnClick = true;
            this.clbSentimentos.ColumnWidth = 185;
            this.clbSentimentos.FormattingEnabled = true;
            this.clbSentimentos.HorizontalScrollbar = true;
            this.clbSentimentos.Location = new System.Drawing.Point(36, 444);
            this.clbSentimentos.MultiColumn = true;
            this.clbSentimentos.Name = "clbSentimentos";
            this.clbSentimentos.Size = new System.Drawing.Size(707, 196);
            this.clbSentimentos.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Selecione todas as sensações experienciadas.";
            // 
            // cbDepressao
            // 
            this.cbDepressao.FormattingEnabled = true;
            this.cbDepressao.Items.AddRange(new object[] {
            "0 ",
            "1",
            "2",
            "3 ",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9  "});
            this.cbDepressao.Location = new System.Drawing.Point(175, 147);
            this.cbDepressao.Name = "cbDepressao";
            this.cbDepressao.Size = new System.Drawing.Size(46, 23);
            this.cbDepressao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nível Depressão (0 a 9):";
            // 
            // cbAnsiedade
            // 
            this.cbAnsiedade.FormattingEnabled = true;
            this.cbAnsiedade.Items.AddRange(new object[] {
            "0 ",
            "1",
            "2",
            "3 ",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9  "});
            this.cbAnsiedade.Location = new System.Drawing.Point(175, 101);
            this.cbAnsiedade.Name = "cbAnsiedade";
            this.cbAnsiedade.Size = new System.Drawing.Size(46, 23);
            this.cbAnsiedade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nível Ansiedade (0 a 9):";
            // 
            // cbDuracao
            // 
            this.cbDuracao.FormattingEnabled = true;
            this.cbDuracao.Items.AddRange(new object[] {
            "Menos de 10 minutos",
            "Entre 10 a 30 minutos",
            "Entre 30 minutos a 1 hora",
            "Entre 1 a 2 horas",
            "Entre 2 a 4 horas",
            "Mais de 5 horas"});
            this.cbDuracao.Location = new System.Drawing.Point(534, 44);
            this.cbDuracao.Name = "cbDuracao";
            this.cbDuracao.Size = new System.Drawing.Size(209, 23);
            this.cbDuracao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duração da crise:";
            // 
            // mtxtHora
            // 
            this.mtxtHora.Location = new System.Drawing.Point(350, 44);
            this.mtxtHora.Mask = "00:00";
            this.mtxtHora.Name = "mtxtHora";
            this.mtxtHora.Size = new System.Drawing.Size(45, 21);
            this.mtxtHora.TabIndex = 3;
            this.mtxtHora.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(34, 814);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(710, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "Se possível, descreva a situação em que se encontrava quando começou a crise, men" +
    "cionando o que pode ter despoletado a mesma e quais foram as suas as ferramentas" +
    " para tentar gerir a situação.";
            // 
            // RegistoCrise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1100);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistoCrise";
            this.Text = "RegistoCrise";
            this.Load += new System.EventHandler(this.RegistoCrise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbDuracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnsiedade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbSentimentos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDepressao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtxtSituacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtPensamentos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox clbSensacoes;
    }
}