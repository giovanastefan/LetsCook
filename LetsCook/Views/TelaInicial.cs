using MySql.Data.MySqlClient;
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
        public static formInicial instanciaLogin;
        Usuario usuario = new Usuario();
        public formInicial()
        {
            InitializeComponent();
            instanciaLogin = this;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.Show();
        }

        public int getId()
        {
            return usuario.getId();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string command = "select * from usuario where usuario=@Usuario and senha=@Senha";

                conexao.consulta(command);
                conexao.cmd.Parameters.AddWithValue("@Usuario", txtNome.Text);
                conexao.cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

                MySqlDataReader leitor = conexao.cmd.ExecuteReader();

                int i = 0;
                while (leitor.Read() && i == 0)
                {
                    usuario.setId(Convert.ToInt32(leitor["id"]));
                    usuario.setUser(leitor["usuario"].ToString());
                    i++;
                }

                conexao.fecharConexao();

                this.Hide();
                PaginaPrincipal principal = new PaginaPrincipal();
                principal.Show();
            } 
            catch
            {
                MessageBox.Show("Usuário ou senha incorreta, tente novamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtSenha.Text = "";
                txtNome.Select();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void formInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
