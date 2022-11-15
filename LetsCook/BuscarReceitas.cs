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
    public partial class BuscarReceitas : Form
    {
        Receitas receitas = new Receitas();
        public BuscarReceitas()
        {
            InitializeComponent();
        }

        private void BuscarReceitas_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarIngredientes_Click(object sender, EventArgs e)
        {
            receitas.adicionarIngrediente(txtIngrediente.Text);

            if (lblIngredientes.Text == "")
            {
                lblIngredientes.Text = "Ingredientes adicionados: " + lblIngredientes.Text + txtIngrediente.Text;
            }
            else
            {
                lblIngredientes.Text = lblIngredientes.Text + ", " + txtIngrediente.Text;

            }

            txtIngrediente.Text = "";
        }

        private void btnBuscarReceitas_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string itens = "";

            foreach (string item in receitas.Ingredientes)
            {
                if (itens == "")
                {
                    itens = itens + item;
                }
                else
                {
                    itens = itens + " " + item;
                }
            }

            conexao.cmd.CommandText = "select * from receita where ingredientes=@ingredientes";
            conexao.cmd.Parameters.AddWithValue("@ingredientes", itens);

            var resultado = conexao.cmd.ExecuteScalar();

            if (resultado != null)
            {
                MessageBox.Show("Receitas Encontradas");
            }

            else
            {
                MessageBox.Show("Nenhuma receita encontrada");
            }

            conexao.fecharConexao();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblIngredientes_Click(object sender, EventArgs e)
        {

        }
    }
}
