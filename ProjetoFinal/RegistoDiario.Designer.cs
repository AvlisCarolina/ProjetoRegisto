namespace ProjetoFinal
{
    partial class RegistoDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistoDiario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtxtDetalhe = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCrise = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clbSentimentos = new System.Windows.Forms.CheckedListBox();
            this.clbSensacoes = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbConvivio = new System.Windows.Forms.ComboBox();
            this.cbAtividadeFisica = new System.Windows.Forms.ComboBox();
            this.cbAlimentacao = new System.Windows.Forms.ComboBox();
            this.cbSono = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rtxtDetalhe);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCrise);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.clbSentimentos);
            this.groupBox1.Controls.Add(this.clbSensacoes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbConvivio);
            this.groupBox1.Controls.Add(this.cbAtividadeFisica);
            this.groupBox1.Controls.Add(this.cbAlimentacao);
            this.groupBox1.Controls.Add(this.cbSono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(772, 1195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório Diário";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LavenderBlush;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(427, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 195);
            this.label10.TabIndex = 29;
            this.label10.Text = resources.GetString("label10.Text");
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 1022);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Submeter Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxtDetalhe
            // 
            this.rtxtDetalhe.Location = new System.Drawing.Point(31, 803);
            this.rtxtDetalhe.Name = "rtxtDetalhe";
            this.rtxtDetalhe.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtDetalhe.Size = new System.Drawing.Size(707, 188);
            this.rtxtDetalhe.TabIndex = 26;
            this.rtxtDetalhe.Text = "";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(29, 769);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(710, 37);
            this.label9.TabIndex = 27;
            this.label9.Text = "Detalhe, o melhor possível, como foi o seu dia, refletindo sobre tudo o que acont" +
    "eceu. Se considerar pertinente, realce situações e conclusões que tenha vivído n" +
    "o decorrer do dia.";
            // 
            // cbCrise
            // 
            this.cbCrise.FormattingEnabled = true;
            this.cbCrise.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbCrise.Location = new System.Drawing.Point(239, 258);
            this.cbCrise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCrise.Name = "cbCrise";
            this.cbCrise.Size = new System.Drawing.Size(53, 23);
            this.cbCrise.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Teve alguma situação de crise hoje?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Selecione todos os sentimentos experienciados.";
            // 
            // clbSentimentos
            // 
            this.clbSentimentos.CheckOnClick = true;
            this.clbSentimentos.ColumnWidth = 185;
            this.clbSentimentos.FormattingEnabled = true;
            this.clbSentimentos.HorizontalScrollbar = true;
            this.clbSentimentos.Location = new System.Drawing.Point(31, 550);
            this.clbSentimentos.MultiColumn = true;
            this.clbSentimentos.Name = "clbSentimentos";
            this.clbSentimentos.Size = new System.Drawing.Size(707, 196);
            this.clbSentimentos.TabIndex = 22;
            // 
            // clbSensacoes
            // 
            this.clbSensacoes.CheckOnClick = true;
            this.clbSensacoes.ColumnWidth = 185;
            this.clbSensacoes.FormattingEnabled = true;
            this.clbSensacoes.HorizontalScrollbar = true;
            this.clbSensacoes.Location = new System.Drawing.Point(31, 326);
            this.clbSensacoes.MultiColumn = true;
            this.clbSensacoes.Name = "clbSensacoes";
            this.clbSensacoes.Size = new System.Drawing.Size(707, 196);
            this.clbSensacoes.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Selecione todas as sensações experienciadas.";
            // 
            // cbConvivio
            // 
            this.cbConvivio.FormattingEnabled = true;
            this.cbConvivio.Items.AddRange(new object[] {
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
            this.cbConvivio.Location = new System.Drawing.Point(239, 217);
            this.cbConvivio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbConvivio.Name = "cbConvivio";
            this.cbConvivio.Size = new System.Drawing.Size(53, 23);
            this.cbConvivio.TabIndex = 11;
            // 
            // cbAtividadeFisica
            // 
            this.cbAtividadeFisica.FormattingEnabled = true;
            this.cbAtividadeFisica.Items.AddRange(new object[] {
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
            this.cbAtividadeFisica.Location = new System.Drawing.Point(239, 178);
            this.cbAtividadeFisica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAtividadeFisica.Name = "cbAtividadeFisica";
            this.cbAtividadeFisica.Size = new System.Drawing.Size(53, 23);
            this.cbAtividadeFisica.TabIndex = 10;
            // 
            // cbAlimentacao
            // 
            this.cbAlimentacao.FormattingEnabled = true;
            this.cbAlimentacao.Items.AddRange(new object[] {
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
            this.cbAlimentacao.Location = new System.Drawing.Point(238, 139);
            this.cbAlimentacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAlimentacao.Name = "cbAlimentacao";
            this.cbAlimentacao.Size = new System.Drawing.Size(53, 23);
            this.cbAlimentacao.TabIndex = 9;
            // 
            // cbSono
            // 
            this.cbSono.FormattingEnabled = true;
            this.cbSono.Items.AddRange(new object[] {
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
            this.cbSono.Location = new System.Drawing.Point(238, 97);
            this.cbSono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSono.Name = "cbSono";
            this.cbSono.Size = new System.Drawing.Size(53, 23);
            this.cbSono.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Como avalia o seu convívio social?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Como avalia a sua atividade física?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Como avalia a sua alimentação?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qualidade de Sono (noite anterior)?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 44);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(495, 1022);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 34);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar ao início";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // RegistoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1100);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistoDiario";
            this.Text = "RegistoDiario";
            this.Load += new System.EventHandler(this.RegistoDiario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSono;
        private System.Windows.Forms.ComboBox cbConvivio;
        private System.Windows.Forms.ComboBox cbAtividadeFisica;
        private System.Windows.Forms.ComboBox cbAlimentacao;
        private System.Windows.Forms.CheckedListBox clbSensacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbSentimentos;
        private System.Windows.Forms.ComboBox cbCrise;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxtDetalhe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnVoltar;
    }
}