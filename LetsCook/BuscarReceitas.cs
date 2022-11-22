using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsCook
{
    public partial class BuscarReceitas : Form
    {
        public static BuscarReceitas instanciaBuscarReceitas;
        Receitas receitas = new Receitas();

        public BuscarReceitas()
        {
            InitializeComponent();
            instanciaBuscarReceitas = this;
        }

        public List<string> itens()
        {
            return receitas.Ingredientes;
        }

        private void BuscarReceitas_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarIngredientes_Click(object sender, EventArgs e)
        {
            if (txtIngrediente.Text.Trim() != "")
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
            }

            txtIngrediente.Text = "";
        }

        private void btnBuscarReceitas_Click(object sender, EventArgs e)
        {
            RetornoReceitas r = new RetornoReceitas();

            PaginaPrincipal.fontes.limparPanel();
            PaginaPrincipal.fontes.alterarPanel(r);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblIngredientes_Click(object sender, EventArgs e)
        {

        }

        private void txtIngrediente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
