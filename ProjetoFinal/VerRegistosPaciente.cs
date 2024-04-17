using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class VerRegistosPaciente : Form
    {
        Connections ligacao = new Connections();
        public VerRegistosPaciente()
        {
            InitializeComponent();
        }

        private void VerRegistosPaciente_Load(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            rbTodos.Checked = true;

            BloquearCampos();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            dataGridView1.Columns.Add("idRegisto", "ID do Registo");
            dataGridView1.Columns.Add("tipoRegisto", "Tipo");
            dataGridView1.Columns.Add("data", "Data");
            dataGridView1.Columns.Add("hora", "Hora da Crise");
            dataGridView1.Columns.Add("nivelAnsiedade", "Ansiedade");
            dataGridView1.Columns.Add("nivelDepressao", "Depressão");
            dataGridView1.Columns.Add("duracaoCrise", "Duração da Crise");
            dataGridView1.Columns.Add("sono", "Qualidade de Sono");
            dataGridView1.Columns.Add("alimentacao", "Qualidade de Alimentacao");
            dataGridView1.Columns.Add("atividadeFisica", "Atividade Física");
            dataGridView1.Columns.Add("convivioSocial", "Convívio Social");
        }

        private void PreencherListaCrise(DateTime dataInicio, DateTime dataFim)
        {
            
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

            string queryListaRegistosCrise = $@"
                SELECT crises.idCrise, date(dataHora) as data, time(dataHora), duracaoCrise, nivelAnsiedade, nivelDepressao FROM crises
                JOIN pacientes ON crises.idPaciente = pacientes.idPaciente
                    WHERE pacientes.idUtilizador = {idUtilizador}
                    AND data between '{dataInicio.ToString("yyyy-MM-dd")}' AND '{dataFim.ToString("yyyy-MM-dd")}' ";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(queryListaRegistosCrise, ligacao.OpenConnection());
                SQLiteDataReader dr = cmd.ExecuteReader();

                int idxLinha = 0;
                while (dr.Read())
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[idxLinha].Cells["idRegisto"].Value = dr[0].ToString();
                    dataGridView1.Rows[idxLinha].Cells["tipoRegisto"].Value = "Crise";
                    dataGridView1.Rows[idxLinha].Cells["data"].Value = dr[1].ToString();
                    dataGridView1.Rows[idxLinha].Cells["hora"].Value = dr[2].ToString();
                    dataGridView1.Rows[idxLinha].Cells["nivelAnsiedade"].Value = dr[4].ToString();
                    dataGridView1.Rows[idxLinha].Cells["nivelDepressao"].Value = dr[5].ToString();
                    dataGridView1.Rows[idxLinha].Cells["duracaoCrise"].Value = dr[3].ToString();
                    dataGridView1.Rows[idxLinha].Cells["sono"].Value = "-";
                    dataGridView1.Rows[idxLinha].Cells["alimentacao"].Value = "-";
                    dataGridView1.Rows[idxLinha].Cells["atividadeFisica"].Value = "-";
                    dataGridView1.Rows[idxLinha].Cells["convivioSocial"].Value = "-";

                    idxLinha++;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ligacao.CloseConnection();
            }
        }

        private void PreencherListaDiario(DateTime dataInicio, DateTime dataFim)
        {
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;

            string queryListaRegistosDiario = $@"
                SELECT diario.idDiario, data, sono, alimentacao, atividadeFisica, convivioSocial FROM diario
                JOIN pacientes ON diario.idPaciente = pacientes.idPaciente
                    WHERE pacientes.idUtilizador = {idUtilizador}
                    AND data between '{dataInicio.ToString("yyyy-MM-dd")}' AND '{dataFim.ToString("yyyy-MM-dd")}'";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(queryListaRegistosDiario, ligacao.OpenConnection());
                SQLiteDataReader dr = cmd.ExecuteReader();

                int idxLinha = dataGridView1.RowCount;
                while (dr.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[idxLinha].Cells["idRegisto"].Value = dr[0].ToString();
                    dataGridView1.Rows[idxLinha].Cells["tipoRegisto"].Value = "Diario";
                    dataGridView1.Rows[idxLinha].Cells["data"].Value = dr[1].ToString();
                    dataGridView1.Rows[idxLinha].Cells["hora"].Value = "-";
                    dataGridView1.Rows[idxLinha].Cells["nivelAnsiedade"].Value = "-";
                    dataGridView1.Rows[idxLinha].Cells["nivelDepressao"].Value = "-";
                    dataGridView1.Rows[idxLinha].Cells["duracaoCrise"].Value = "-";
                    dataGridView1.Rows[idxLinha].Cells["sono"].Value = dr[2].ToString();
                    dataGridView1.Rows[idxLinha].Cells["alimentacao"].Value = dr[3].ToString();
                    dataGridView1.Rows[idxLinha].Cells["atividadeFisica"].Value = dr[4].ToString();
                    dataGridView1.Rows[idxLinha].Cells["convivioSocial"].Value = dr[5].ToString();

                    idxLinha++;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ligacao.CloseConnection();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            BloquearCampos();
            rbTodos.Checked = true;
            dataGridView1.Rows.Clear();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            txtIDRegisto.Text = dataGridView1.SelectedRows[0].Cells["idRegisto"].Value.ToString();
            txtTipoRegisto.Text = dataGridView1.SelectedRows[0].Cells["tipoRegisto"].Value.ToString();
            txtData.Text = dataGridView1.SelectedRows[0].Cells["data"].Value.ToString();
            mtxtHora.Text = dataGridView1.SelectedRows[0].Cells["hora"].Value.ToString();
            txtNivelAnsiedade.Text = dataGridView1.SelectedRows[0].Cells["nivelAnsiedade"].Value.ToString();
            txtNivelDepressao.Text = dataGridView1.SelectedRows[0].Cells["nivelDepressao"].Value.ToString();
            txtDuracao.Text = dataGridView1.SelectedRows[0].Cells["duracaoCrise"].Value.ToString();
            txtNivelSono.Text = dataGridView1.SelectedRows[0].Cells["sono"].Value.ToString();
            txtNivelAlimentacao.Text = dataGridView1.SelectedRows[0].Cells["alimentacao"].Value.ToString();
            txtNivelAtividadeFisica.Text = dataGridView1.SelectedRows[0].Cells["atividadeFisica"].Value.ToString();
            txtNivelConvivioSocial.Text = dataGridView1.SelectedRows[0].Cells["convivioSocial"].Value.ToString();

            if (txtTipoRegisto.Text == "Crise")
            {
                QueryCriseRelatorio();
                QueryCriseSensacoes();
                QueryCriseSentimentos();
            }
            else if (txtTipoRegisto.Text == "Diario") 
            {
                QueryDiarioRelatorio();
                QueryDiarioSensacoes();
                QueryDiarioSentimentos();
                            
            }
            else
            {
                MessageBox.Show("Erro. Verifique se a seleção foi feita corretamente.");
            }
        }
        
        private void QueryCriseRelatorio()
        {
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;
            string queryRelatorioCrise = $@"
                    SELECT pacientes.nome, descricaoSituacao, pensamentosImagens FROM crises 
                        JOIN pacientes ON crises.idPaciente = pacientes.idPaciente
                            WHERE pacientes.idUtilizador = {idUtilizador}        
                            AND crises.idCrise = {txtIDRegisto.Text};";

            SQLiteCommand cmd = new SQLiteCommand(queryRelatorioCrise, ligacao.OpenConnection());
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                txtNomePaciente.Text = dataReader[0].ToString();
                rtxtDetalhes.Text = $"Pensamentos/Imagens: {dataReader[1].ToString()}\n\nDescrição Situação de Crise: {dataReader[2].ToString()}";

                dataReader.Close();
            }
        }

        private void QueryCriseSensacoes()
        {
            string querySensacoes = $@"
                    SELECT  descricao FROM criseListaSensacoes
	                    JOIN sensacoes ON criseListaSensacoes.idSensacao = sensacoes.idSensacao
		                    WHERE criseListaSensacoes.idCrise = {txtIDRegisto.Text};";

            SQLiteCommand cmd1 = new SQLiteCommand(querySensacoes, ligacao.OpenConnection());
            SQLiteDataReader dataReader1 = cmd1.ExecuteReader();

            string texto1 = "";
            while (dataReader1.Read())
            {
                string descricaoSensacao = dataReader1[0].ToString();
                texto1 += $"{descricaoSensacao}; ";
            }
            rtxtSensacoes.Text = texto1;

            dataReader1.Close();
        }

        private void QueryCriseSentimentos()
        {
            string querySentimentos = $@"
                SELECT  descricao FROM criseListaSentimentos
                    JOIN sentimentos ON criseListaSentimentos.idSentimento = sentimentos.idSentimento
                        WHERE criseListaSentimentos.idCrise = {txtIDRegisto.Text};";
            
            SQLiteCommand cmd2 = new SQLiteCommand(querySentimentos, ligacao.OpenConnection());
            SQLiteDataReader dataReader2 = cmd2.ExecuteReader();

            string texto2 = "";
            while (dataReader2.Read())
            {
                string descricaoSentimento = dataReader2[0].ToString();
                texto2 += $"{descricaoSentimento}; ";
            }
            rtxtSentimentos.Text = texto2;

            dataReader2.Close();
        }

        private void QueryDiarioRelatorio()
        {
            int idUtilizador;
            idUtilizador = ((FormInicial)this.MdiParent).atualLogin;
            string queryRelatorioDiario = $@"
                    SELECT pacientes.nome, detalhes FROM diario
                        JOIN pacientes ON diario.idPaciente = pacientes.idPaciente
                            WHERE pacientes.idUtilizador = {idUtilizador}        
                            AND diario.idDiario = {txtIDRegisto.Text};";

            SQLiteCommand cmd = new SQLiteCommand(queryRelatorioDiario, ligacao.OpenConnection());
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                txtNomePaciente.Text = dataReader[0].ToString();
                rtxtDetalhes.Text = dataReader[1].ToString();

                dataReader.Close();
            }
        }

        private void QueryDiarioSensacoes()
        {
            string querySensacoes = $@"
                    SELECT  descricao FROM DiarioListaSensacoes
	                    JOIN sensacoes ON DiarioListaSensacoes.idSensacao = sensacoes.idSensacao
		                    WHERE DiarioListaSensacoes.idDiario = {txtIDRegisto.Text};";

            SQLiteCommand cmd1 = new SQLiteCommand(querySensacoes, ligacao.OpenConnection());
            SQLiteDataReader dataReader1 = cmd1.ExecuteReader();

            string texto1 = "";
            while (dataReader1.Read())
            {
                string descricaoSensacao = dataReader1[0].ToString();
                texto1 += $"{descricaoSensacao}; ";
            }
            rtxtSensacoes.Text = texto1;

            dataReader1.Close();
        }

        private void QueryDiarioSentimentos()
        {
            string querySentimentos = $@"
                SELECT  descricao FROM DiarioListaSentimentos
                    JOIN sentimentos ON DiarioListaSentimentos.idSentimento = sentimentos.idSentimento
                        WHERE DiarioListaSentimentos.idDiario = {txtIDRegisto.Text};";

            SQLiteCommand cmd2 = new SQLiteCommand(querySentimentos, ligacao.OpenConnection());
            SQLiteDataReader dataReader2 = cmd2.ExecuteReader();

            string texto2 = "";
            while (dataReader2.Read())
            {
                string descricaoSentimento = dataReader2[0].ToString();
                texto2 += $"{descricaoSentimento}; ";
            }
            rtxtSentimentos.Text = texto2;

            dataReader2.Close();
        }

        private void BloquearCampos()
        {
            txtIDRegisto.Enabled = false;
            txtTipoRegisto.Enabled = false;
            txtData.Enabled = false;
            mtxtHora.Enabled = false;
            txtNivelAnsiedade.Enabled = false;
            txtNivelDepressao.Enabled = false;
            txtDuracao.Enabled = false;
            txtNivelSono.Enabled = false;
            txtNivelAlimentacao.Enabled = false;
            txtNivelAtividadeFisica.Enabled = false;
            txtNivelConvivioSocial.Enabled = false;
            rtxtDetalhes.Enabled = false;
            rtxtSensacoes.Enabled = false;
            rtxtSentimentos.Enabled = false;

            txtIDRegisto.Text = string.Empty;
            txtTipoRegisto.Text = string.Empty;
            txtData.Text = string.Empty;
            mtxtHora.Text = string.Empty;
            txtNivelAnsiedade.Text = string.Empty;
            txtNivelDepressao.Text = string.Empty;
            txtDuracao.Text = string.Empty;
            txtNivelSono.Text = string.Empty;
            txtNivelAlimentacao.Text = string.Empty;
            txtNivelAtividadeFisica.Text = string.Empty;
            txtNivelConvivioSocial.Text = string.Empty;
            rtxtDetalhes.Text = string.Empty;
            rtxtSensacoes.Text = string.Empty;
            rtxtSentimentos.Text = string.Empty;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DateTime dataInicio, dataFim;

            dataInicio = dtpInicio.Value;
            dataFim = dtpFim.Value;

            if (dataInicio <= dataFim)
            {
                if (rbCrise.Checked)
                {
                    PreencherListaCrise(dataInicio, dataFim);
                }
                else if (rbDiario.Checked)
                {
                    PreencherListaDiario(dataInicio, dataFim);
                }
                else
                {
                    PreencherListaCrise(dataInicio, dataFim);
                    PreencherListaDiario(dataInicio, dataFim);
                }
            }

            else 
            { 
                MessageBox.Show("Erro. Data de início superior à data de fim."); 
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
