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
        private string data_source = "Server=sql9.freemysqlhosting.net;Database=sql9576945;Uid=sql9576945;Pwd=k5A97GfcYr";
        public MySqlConnection Connection;
        public MySqlCommand cmd;

        public void abrirConexao()
        {
            try
            {
                Connection = new MySqlConnection(data_source);
                Connection.Open();
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

        public MySqlCommand consulta(string comando)
        {
            Connection = new MySqlConnection(data_source);
            cmd = new MySqlCommand(comando, Connection);
            Connection.Open();
            return cmd;
        }

        public void fecharConexao()
        {
            Connection.Close();
        }

    }
}