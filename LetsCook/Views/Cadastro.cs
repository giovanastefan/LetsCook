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
            Conexao conexao = new Conexao();

            Usuario usuario = new Usuario();
            usuario.setName(txtNome.Text);
            usuario.setUser(txtUsuario.Text);
            usuario.setPassword(txtSenha.Text);

            try
            {
                string verificacao = "SELECT * from usuario where usuario = @usuario";


                conexao.consulta(verificacao);
                conexao.cmd.Parameters.AddWithValue("@usuario", usuario.getUser());
                var resultado = conexao.cmd.ExecuteScalar();

                if (resultado != null)
                {
                    MessageBox.Show("Usuário ja cadastrado!");
                }

                else
                {
                    string command = "INSERT INTO usuario (nome, usuario, senha) " +
                                     "VALUES (@nome, @usuario, @senha)";


                    conexao.consulta(command);

                    conexao.cmd.Parameters.AddWithValue("@nome", usuario.getName());
                    conexao.cmd.Parameters.AddWithValue("@usuario", usuario.getUser());
                    conexao.cmd.Parameters.AddWithValue("@senha", usuario.getPassword());

                    conexao.cmd.Prepare();

                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Contado inserido com sucesso!",
                                     "Sucesso!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
                    txtNome.Clear();
                    txtUsuario.Clear();
                    txtSenha.Clear();
            }
            catch
            {
                MessageBox.Show("Algo deu errado, tente novamente!");
            }
            finally
            {
                conexao.fecharConexao();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            formInicial telainicial = new formInicial();
            this.Hide();
            telainicial.Show();
        }
    }
}
