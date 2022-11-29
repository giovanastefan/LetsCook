using LetsCook.Classes;
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
        Classes.Receitas receitas = new Classes.Receitas();
        Conexao conexao = new Conexao();

        public BuscarReceitas()
        {
            InitializeComponent();
            instanciaBuscarReceitas = this;
        }

        public List<string> itens()
        {
            return receitas.Ingredientes;
        }

        private void btnAdicionarIngredientes_Click(object sender, EventArgs e)
        {
            if (txtIngrediente.Text.Trim() != "")
            {
                receitas.adicionarIngrediente(txtIngrediente.Text.Trim());
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
            /* parametrosBusca += " LIKE %" + itens().ElementAt(i) + "% AND descricao ";*/
                
            RetornoReceitas r = new RetornoReceitas();

            PaginaPrincipal.fontes.limparPanel();
            PaginaPrincipal.fontes.alterarPanel(r);
            PaginaPrincipal.fontes.alterarPanel(r);
        }  
    }
}
