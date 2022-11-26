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
using LetsCook.Classes;

namespace LetsCook
{
    public partial class RetornoReceitas : Form
    {
        private int contem;
        private Receitas[] receitas;
        DataTable receitasEncontradas = new DataTable();          

        Conexao conexao = new Conexao();

        public RetornoReceitas()
        {
            InitializeComponent();
        }   

        public void retornaReceitas(List<string> ingredientesReceita)
        {
            try
            {               
                string sql = "SELECT id, ingredientes from receitas";
                
                List<string[]> total = new List<string[]>();
                List<int> retorno = new List<int>();
                string[] itens = new string[10];
                conexao.consulta(sql);

                MySqlDataReader leitor = conexao.cmd.ExecuteReader();

                while (leitor.Read())
                {
                    itens = leitor["ingredientes"].ToString().Split(' ');
                    string id = leitor["id"].ToString();
                    itens.Append(id);
                    total.Add(itens);
                }

                conexao.fecharConexao();

                int contItens = ingredientesReceita.Count();
                contem = 0;

                foreach (string[] i in total)
                {
                    contem = 0;
                    foreach (string j in i)
                    {
                        //colocar LIKE %
                        if (ingredientesReceita.Contains(j))
                        {
                            contem++;
                        }
                    }
                    if (contem == i.Length)
                    {
                        retorno.Add(total.IndexOf(i) + 1);
                    }
                }

                foreach (int i in retorno)
                {

                    string command = "SELECT * from receitas WHERE id = @id";                   

                    conexao.consulta(command);
                    conexao.cmd.Parameters.AddWithValue("@id", i);

                    MySqlDataReader final = conexao.cmd.ExecuteReader();
                    List<string[]> lista = new List<string[]>();

                    receitasEncontradas.Load(final);



                    receitas = new Receitas[contem];

                    //int j = 0;
                    while (final.Read())
                    {
                        /*receitas[i].id = final.GetInt32(0);
                        receitas[i].titulo = final.GetString(1);
                        receitas[i].ingrediente = final.GetString(2);
                        receitas[i].modo_preparo = final.GetString(3);*/

                        

                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Ops, algo deu errado, tente novamente!");
            }
            finally
            {
                conexao.fecharConexao();
            }

        }

        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();



            CardReceita[] lista = new CardReceita[1000];

            /*for (int i = 0; i < contem; i++)
            {
                lista[i] = new CardReceita();

                lista[i].Titulo = receitas[i].titulo;
                lista[i].Ingredientes = receitas[i].ingrediente;
                lista[i].Descricao = receitas[i].modo_preparo;

                flowLayoutPanel1.Controls.Add(lista[i]);
            }*/

            int j = 0;

            foreach(DataRow receitas in receitasEncontradas.Rows)
            {
                lista[j] = new CardReceita();

                lista[j].Titulo = receitas["titulo"].ToString();
                lista[j].Ingredientes = receitas["ingredientes"].ToString();
                lista[j].Descricao = receitas["modo_preparo"].ToString();

                flowLayoutPanel1.Controls.Add(lista[j]);

                j++;
            }
        }

        private void RetornoReceitas_Load(object sender, EventArgs e)
        {
            var r = BuscarReceitas.instanciaBuscarReceitas.itens();

            retornaReceitas(r);
            GenerateDynamicUserControl();

            MessageBox.Show(" Receitas encontradas: " + contem);


        }

        private void cardReceita1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
