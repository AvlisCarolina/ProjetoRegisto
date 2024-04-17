namespace ProjetoFinal
{
    partial class VerRegistosPaciente
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDiario = new System.Windows.Forms.RadioButton();
            this.rbCrise = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtxtHora = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rtxtDetalhes = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.rtxtSentimentos = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIDRegisto = new System.Windows.Forms.TextBox();
            this.rtxtSensacoes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTipoRegisto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNivelDepressao = new System.Windows.Forms.TextBox();
            this.txtNivelAnsiedade = new System.Windows.Forms.TextBox();
            this.txtNivelConvivioSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNivelAtividadeFisica = new System.Windows.Forms.TextBox();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtNivelAlimentacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNivelSono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.dtpFim);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbDiario);
            this.groupBox1.Controls.Add(this.rbCrise);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(773, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Registos";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::ProjetoFinal.Properties.Resources.b_search1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(452, 75);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(142, 35);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar Registos";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::ProjetoFinal.Properties.Resources.b_drop;
            this.btnLimpar.Location = new System.Drawing.Point(612, 75);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 35);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar Pesquisa";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "yyyy-MM-dd";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(332, 30);
            this.dtpFim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFim.Size = new System.Drawing.Size(108, 21);
            this.dtpFim.TabIndex = 8;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "yyyy-MM-dd";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(124, 30);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(108, 21);
            this.dtpInicio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Fim:";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(276, 66);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(59, 19);
            this.rbTodos.TabIndex = 5;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Início:";
            // 
            // rbDiario
            // 
            this.rbDiario.AutoSize = true;
            this.rbDiario.Location = new System.Drawing.Point(201, 66);
            this.rbDiario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.Size = new System.Drawing.Size(58, 19);
            this.rbDiario.TabIndex = 2;
            this.rbDiario.TabStop = true;
            this.rbDiario.Text = "Diário";
            this.rbDiario.UseVisualStyleBackColor = true;
            // 
            // rbCrise
            // 
            this.rbCrise.AutoSize = true;
            this.rbCrise.Location = new System.Drawing.Point(132, 66);
            this.rbCrise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbCrise.Name = "rbCrise";
            this.rbCrise.Size = new System.Drawing.Size(53, 19);
            this.rbCrise.TabIndex = 1;
            this.rbCrise.TabStop = true;
            this.rbCrise.Text = "Crise";
            this.rbCrise.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Registo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnVisualizar);
            this.groupBox2.Location = new System.Drawing.Point(14, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(773, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de registos encontrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(708, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Image = global::ProjetoFinal.Properties.Resources.b_view;
            this.btnVisualizar.Location = new System.Drawing.Point(532, 194);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(208, 35);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar Registo Selecionado";
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtxtHora);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.txtDuracao);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.rtxtDetalhes);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnImprimir);
            this.groupBox3.Controls.Add(this.rtxtSentimentos);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtIDRegisto);
            this.groupBox3.Controls.Add(this.rtxtSensacoes);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtTipoRegisto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtNivelDepressao);
            this.groupBox3.Controls.Add(this.txtNivelAnsiedade);
            this.groupBox3.Controls.Add(this.txtNivelConvivioSocial);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNivelAtividadeFisica);
            this.groupBox3.Controls.Add(this.txtNomePaciente);
            this.groupBox3.Controls.Add(this.txtNivelAlimentacao);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtNivelSono);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(13, 380);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(773, 659);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Registo";
            // 
            // mtxtHora
            // 
            this.mtxtHora.Location = new System.Drawing.Point(292, 142);
            this.mtxtHora.Mask = "00:00";
            this.mtxtHora.Name = "mtxtHora";
            this.mtxtHora.Size = new System.Drawing.Size(45, 21);
            this.mtxtHora.TabIndex = 28;
            this.mtxtHora.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(249, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 27;
            this.label18.Text = "Hora:";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(121, 142);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(104, 21);
            this.txtData.TabIndex = 26;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Enabled = false;
            this.txtDuracao.Location = new System.Drawing.Point(507, 99);
            this.txtDuracao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(203, 21);
            this.txtDuracao.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(397, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "Duração da crise:";
            // 
            // rtxtDetalhes
            // 
            this.rtxtDetalhes.Enabled = false;
            this.rtxtDetalhes.Location = new System.Drawing.Point(41, 520);
            this.rtxtDetalhes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtxtDetalhes.Name = "rtxtDetalhes";
            this.rtxtDetalhes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtDetalhes.Size = new System.Drawing.Size(695, 116);
            this.rtxtDetalhes.TabIndex = 23;
            this.rtxtDetalhes.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 501);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Outras Informações";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::ProjetoFinal.Properties.Resources.b_print;
            this.btnImprimir.Location = new System.Drawing.Point(609, 30);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 37);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir Registo";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // rtxtSentimentos
            // 
            this.rtxtSentimentos.Enabled = false;
            this.rtxtSentimentos.Location = new System.Drawing.Point(41, 403);
            this.rtxtSentimentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtxtSentimentos.Name = "rtxtSentimentos";
            this.rtxtSentimentos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtSentimentos.Size = new System.Drawing.Size(695, 86);
            this.rtxtSentimentos.TabIndex = 21;
            this.rtxtSentimentos.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 383);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "Sentimentos anotados";
            // 
            // txtIDRegisto
            // 
            this.txtIDRegisto.Enabled = false;
            this.txtIDRegisto.Location = new System.Drawing.Point(123, 96);
            this.txtIDRegisto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDRegisto.Name = "txtIDRegisto";
            this.txtIDRegisto.Size = new System.Drawing.Size(64, 21);
            this.txtIDRegisto.TabIndex = 1;
            // 
            // rtxtSensacoes
            // 
            this.rtxtSensacoes.Enabled = false;
            this.rtxtSensacoes.Location = new System.Drawing.Point(41, 285);
            this.rtxtSensacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtxtSensacoes.Name = "rtxtSensacoes";
            this.rtxtSensacoes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtSensacoes.Size = new System.Drawing.Size(695, 86);
            this.rtxtSensacoes.TabIndex = 19;
            this.rtxtSensacoes.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID do Registo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 265);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Sensações anotadas";
            // 
            // txtTipoRegisto
            // 
            this.txtTipoRegisto.Enabled = false;
            this.txtTipoRegisto.Location = new System.Drawing.Point(282, 98);
            this.txtTipoRegisto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTipoRegisto.Name = "txtTipoRegisto";
            this.txtTipoRegisto.Size = new System.Drawing.Size(100, 21);
            this.txtTipoRegisto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo Registo:";
            // 
            // txtNivelDepressao
            // 
            this.txtNivelDepressao.Enabled = false;
            this.txtNivelDepressao.Location = new System.Drawing.Point(610, 237);
            this.txtNivelDepressao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNivelDepressao.Name = "txtNivelDepressao";
            this.txtNivelDepressao.Size = new System.Drawing.Size(100, 21);
            this.txtNivelDepressao.TabIndex = 17;
            // 
            // txtNivelAnsiedade
            // 
            this.txtNivelAnsiedade.Enabled = false;
            this.txtNivelAnsiedade.Location = new System.Drawing.Point(610, 190);
            this.txtNivelAnsiedade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNivelAnsiedade.Name = "txtNivelAnsiedade";
            this.txtNivelAnsiedade.Size = new System.Drawing.Size(100, 21);
            this.txtNivelAnsiedade.TabIndex = 16;
            // 
            // txtNivelConvivioSocial
            // 
            this.txtNivelConvivioSocial.Enabled = false;
            this.txtNivelConvivioSocial.Location = new System.Drawing.Point(351, 232);
            this.txtNivelConvivioSocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNivelConvivioSocial.Name = "txtNivelConvivioSocial";
            this.txtNivelConvivioSocial.Size = new System.Drawing.Size(100, 21);
            this.txtNivelConvivioSocial.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data Registo:";
            // 
            // txtNivelAtividadeFisica
            // 
            this.txtNivelAtividadeFisica.Enabled = false;
            this.txtNivelAtividadeFisica.Location = new System.Drawing.Point(352, 189);
            this.txtNivelAtividadeFisica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNivelAtividadeFisica.Name = "txtNivelAtividadeFisica";
            this.txtNivelAtividadeFisica.Size = new System.Drawing.Size(100, 21);
            this.txtNivelAtividadeFisica.TabIndex = 14;
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Enabled = false;
            this.txtNomePaciente.Location = new System.Drawing.Point(123, 46);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(420, 21);
            this.txtNomePaciente.TabIndex = 9;
            // 
            // txtNivelAlimentacao
            // 
            this.txtNivelAlimentacao.Enabled = false;
            this.txtNivelAlimentacao.Location = new System.Drawing.Point(125, 227);
            this.txtNivelAlimentacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNivelAlimentacao.Name = "txtNivelAlimentacao";
            this.txtNivelAlimentacao.Size = new System.Drawing.Size(100, 21);
            this.txtNivelAlimentacao.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Paciente:";
            // 
            // txtNivelSono
            // 
            this.txtNivelSono.Enabled = false;
            this.txtNivelSono.Location = new System.Drawing.Point(125, 189);
            this.txtNivelSono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNivelSono.Name = "txtNivelSono";
            this.txtNivelSono.Size = new System.Drawing.Size(100, 21);
            this.txtNivelSono.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(488, 240);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Nível de Depressão:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Alimentação:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(488, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Nível de Asiedade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Atividade Física:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Convívio Social:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(617, 17);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 28);
            this.btnVoltar.TabIndex = 31;
            this.btnVoltar.Text = "Fechar Pesquisa";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // VerRegistosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1061);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VerRegistosPaciente";
            this.Text = "VerRegistosPaciente";
            this.Load += new System.EventHandler(this.VerRegistosPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDiario;
        private System.Windows.Forms.RadioButton rbCrise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIDRegisto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNivelDepressao;
        private System.Windows.Forms.TextBox txtNivelAnsiedade;
        private System.Windows.Forms.TextBox txtNivelConvivioSocial;
        private System.Windows.Forms.TextBox txtNivelAtividadeFisica;
        private System.Windows.Forms.TextBox txtNivelAlimentacao;
        private System.Windows.Forms.TextBox txtNivelSono;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.RichTextBox rtxtSentimentos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rtxtSensacoes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.RichTextBox rtxtDetalhes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTipoRegisto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtHora;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnVoltar;
    }
}