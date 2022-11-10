using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace LetsCook
{
    

    public partial class Cadastro : Form
    {

        private MySqlConnection Connection;
        private string data_source = "Server=sql10.freesqldatabase.com;Database=sql10556505;Uid=sql10556505;Pwd=42bCRdmYVL";

        public Cadastro()
        {
            InitializeComponent();

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Connection = new MySqlConnection(data_source);
                Connection.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Connection;

                cmd.CommandText = "INSERT INTO usuario (nome, usuario, senha) " +
                                     "VALUES (@nome, @usuario, @senha)";

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Contado inserido com sucesso!",
                                 "Sucesso!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu " + ex.Message,
                                    "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_StyleChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtSenha.PasswordChar = '*';
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
