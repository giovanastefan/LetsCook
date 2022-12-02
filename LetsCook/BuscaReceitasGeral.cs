using LetsCook.Classes;
using MySql.Data.MySqlClient;
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
    public partial class BuscaReceitasGeral : Form
    {
        Conexao conexao = new Conexao();
        Receitas[] receitas = new Receitas[0];
        List<int> listagem = new List<int>();
        public BuscaReceitasGeral()
        {
            InitializeComponent();
        }

        private void retorno()
        {
            listagem.Clear();
            string a = txtIngrediente.Text.Trim();
            try
            {
                string sql = "select * from receitas where ingredientes like \"%"+ a +"%\"";
                conexao.consulta(sql);
                MySqlDataReader leitor = conexao.cmd.ExecuteReader();

                while (leitor.Read())
                {
                    listagem.Add(Convert.ToInt32(leitor["id"]));
                }

                conexao.fecharConexao();

                receitas = new Receitas[listagem.Count()];

                int k = 0;
                foreach (int i in listagem)
                {

                    string command = "SELECT * from receitas WHERE id = @id";

                    conexao.consulta(command);
                    conexao.cmd.Parameters.AddWithValue("@id", i);

                    MySqlDataReader final = conexao.cmd.ExecuteReader();

                    while (final.Read())
                    {
                        receitas[k] = new Receitas();

                        receitas[k].id = Convert.ToInt32(final["id"]);
                        receitas[k].titulo = final.GetString(1);
                        receitas[k].ingrediente = final.GetString(2);
                        receitas[k].modo_preparo = final.GetString(3);
                    }

                    k += 1;
                }
            }
            catch
            {
                MessageBox.Show("Algo deu errado! Tente novamente");
            }
            finally
            {
                conexao.fecharConexao();
            }
        }

        private void btnAdicionarIngredientes_Click(object sender, EventArgs e)
        {
            retorno();
            GenerateDynamicUserControl();

        }

        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            CardReceita[] lista = new CardReceita[listagem.Count];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = new CardReceita();
                lista[i].setId(receitas[i].id);
                lista[i].Titulo = receitas[i].titulo;
                lista[i].Ingredientes = receitas[i].ingrediente;
                lista[i].Descricao = receitas[i].modo_preparo;

                flowLayoutPanel1.Controls.Add(lista[i]);
            }
        }

        private void BuscaReceitasGeral_Load(object sender, EventArgs e)
        {
            cardReceita1.Hide();
        }
    }
}
