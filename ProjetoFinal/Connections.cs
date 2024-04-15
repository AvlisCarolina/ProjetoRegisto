using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    internal class Connections
    {
        public SQLiteConnection OpenConnection()
        {
            var connection = new SQLiteConnection(DatabaseHelper.connectionString);
            // Método responsável por abrir a conexão com o banco de dados.
            try
            {
                connection.Open();
                return connection;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao iniciar conexão." + ex.Message);
                throw (ex);
            }
        }

        public SQLiteConnection CloseConnection()
        {
            var connection = new SQLiteConnection(DatabaseHelper.connectionString);
            // Método responsável por abrir a conexão com o banco de dados.
            try
            {
                connection.Close();
                return connection;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                return connection;
            }
        }

        /*public void PreencherDataGridView1(ref DataGridView dgv)
        {
            var connection = OpenConnection();

            try
            {

                var command = new SQLiteCommand(connection);
                string selectQuery = @"
                SELECT idUtilizador, email, userName, utilizadores.idAcesso, nivelAcesso
                    FROM utilizadores
                    JOIN acessos on utilizadores.idAcesso = acessos.idAcesso
                    ORDER BY idUtilizador;";

                command.CommandText = selectQuery;
                command.ExecuteNonQuery();
                SQLiteDataReader dr = command.ExecuteReader();

                int idxLinha = 0;
                while (dr.Read())
                {
                    dgv.Rows.Add();
                    dgv.Rows[idxLinha].Cells["idUtilizador"].Value = dr[0].ToString();
                    dgv.Rows[idxLinha].Cells["email"].Value = dr[1].ToString();
                    dgv.Rows[idxLinha].Cells["userName"].Value = dr[2].ToString();
                    dgv.Rows[idxLinha].Cells["nivelAcesso"].Value = dr[3].ToString() + " - " + dr[4].ToString();
                    idxLinha++;
                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }*/
    }
}
