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
            string data_source = "Server=sql9.freemysqlhosting.net;Database=sql9576945;Uid=sql9576945;Pwd=k5A97GfcYr";
            try
            {
                MySqlConnection conn = new MySqlConnection(data_source);

                string sql = "SELECT id, ingredientes from receitas";
                string[] itens = new string[10];
                List<string[]> total = new List<string[]>();
                List<int> retorno = new List<int>();


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    itens = leitor["ingredientes"].ToString().Split(' ');
                    string id = leitor["id"].ToString();
                    itens.Append(id);
                    total.Add(itens);
                }

                conn.Close();

                int contItens = receitas.Ingredientes.Count();
                int contem = 0;

                foreach(string[] i in total)
                {
                    contem = 0;
                    foreach(string j in i)
                    {
                        if (receitas.Ingredientes.Contains(j))
                        {
                            contem++;
                        }
                    }
                    if(contem == i.Length)
                    {
                        retorno.Add(total.IndexOf(i) + 1);
                    }
                }

                foreach(int i in retorno)
                {

                    string comand = "SELECT * from receitas WHERE id = @id";

                    MySqlCommand r = new MySqlCommand(comand, conn);
                    r.Parameters.AddWithValue("@id", i);

                    conn.Open();

                    MySqlDataReader final = r.ExecuteReader();

                    while (final.Read())
                    {
                        MessageBox.Show(final["titulo"].ToString());
                    }

                    conn.Close();
                }


            }
            catch
            {
                MessageBox.Show("nao");
            }
            finally
            {
            }
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
