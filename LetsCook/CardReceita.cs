using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsCook
{
    public partial class CardReceita : UserControl
    {
        public CardReceita()
        {
            InitializeComponent();
        }

        private int id;
        private string _titulo;
        private string _ingredientes;
        private string _descricao;

        public void setId(int id)
        {
            this.id = id;
        }

       
        [Category("Custom Props")]
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; labelTitulo.Text = value; }
        }

        [Category("Custom Props")]
        public string Ingredientes
        {
            get { return _ingredientes; }
            set { _ingredientes = value; labelIngredientes.Text = value; }
        }

        [Category("Custom Props")]
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; richTextBox1.Text = value; }
        }

        private void buttonFavoritar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                Usuario usuario = new Usuario();

                string comando = "INSERT INTO receitas_favoritas (cod_receita, cod_usuario) " +
                                     "VALUES (@cod_receita, @cod_usuario)";

                conexao.consulta(comando);

                conexao.cmd.Parameters.AddWithValue("@cod_receita", id);
                conexao.cmd.Parameters.AddWithValue("@cod_usuario", formInicial.instanciaLogin.getId());

                conexao.cmd.Prepare();

                conexao.cmd.ExecuteNonQuery();

                conexao.fecharConexao();

                MessageBox.Show("Receita favoritada com sucesso!");
            }
            catch {
                MessageBox.Show("Ops, algo deu errado tente novamente");
            }
        }

        private void CardReceita_Load(object sender, EventArgs e)
        {

        }
    }
}

