using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsCook
{
    public partial class formInicial : Form
    {
        public formInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.Show();
        }

        private void formInicial_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
         
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            conexao.cmd.CommandText = "select * from usuario where usuario=@Usuario and senha=@Senha";
            conexao.cmd.Parameters.AddWithValue("@Usuario", txtNome.Text);
            conexao.cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
            
            var resultado = conexao.cmd.ExecuteScalar();

            if (resultado != null)
            {
                MessageBox.Show("Conectado!!");
            }

            else
            {
                MessageBox.Show("Usuário ou senha incorreta, tente novamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtSenha.Text = "";
                txtNome.Select();
            }

            conexao.fecharConexao();
        }
    }
}
