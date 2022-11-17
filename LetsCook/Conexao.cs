using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsCook
{
    internal class Conexao
    {
        public MySqlConnection Connection;
        private string data_source = "Server=sql9.freemysqlhosting.net;Database=sql9576945;Uid=sql9576945;Pwd=k5A97GfcYr";
        public MySqlCommand cmd = new MySqlCommand();

        public Conexao()
        {
            try
            {
                Connection = new MySqlConnection(data_source);
                Connection.Open();

                cmd.Connection = Connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharConexao()
        {
            Connection.Close();
        }

    }
}
