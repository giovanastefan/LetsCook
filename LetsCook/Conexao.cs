using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsCook
{
    internal class Conexao
    {
        private MySqlConnection Connection;
        private string data_source = "Server=sql10.freesqldatabase.com;Database=sql10556505;Uid=sql10556505;Pwd=42bCRdmYVL";
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
                throw ex;
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
