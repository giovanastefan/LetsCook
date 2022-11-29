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
        Receitas[] receitas = new Receitas[0];
        List<int> retorno = new List<int>();

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
                
                string[] itens = new string[10];
                conexao.consulta(sql);

                MySqlDataReader leitor = conexao.cmd.ExecuteReader();

                while (leitor.Read())
                {
                    itens = leitor["ingredientes"].ToString().Split(' '); //pega todos os ingredientes das receitas da consulta, separa por espaço, e salva no vetor 'leitor'
                    string id = leitor["id"].ToString(); //pega todos os ids das receitas da consulta e salva na string id
                    itens.Append(id);
                    total.Add(itens); //adiciona o vetor com os ingredientes a lista de vetores 'total'
                }

                conexao.fecharConexao();

                int contItens = ingredientesReceita.Count();
                int contem = 0;

                foreach (string[] i in total) //passa por todos os vetores de string que estão na lista 'total'.
                {
                    contem = 0;
                    foreach (string j in i) //passa por todo o vetor de string 'i' encontrado no foreach anterior.
                    {
                        if (ingredientesReceita.Contains(j)) //verifica se as strings da verificação anterior estão presentes na lista de ingredientes passada como parâmetro no método.
                        {
                            contem++;
                        }
                    }
                    if (contem == i.Length) //verifica se o numero de ingredientes da lista é igual ao tamanho do vetor 'i'. 
                    {
                        retorno.Add(total.IndexOf(i) + 1); //adiciona na lista de retorno o id do vetor de strings que contem na lista total.
                    }
                }

                receitas = new Receitas[retorno.Count()];

                int k = 0;
                foreach (int i in retorno)
                {

                    string command = "SELECT * from receitas WHERE id = @id";                   

                    conexao.consulta(command);
                    conexao.cmd.Parameters.AddWithValue("@id", i);

                    MySqlDataReader final = conexao.cmd.ExecuteReader();

                    while (final.Read())
                    {
                        receitas[k] = new Receitas();

                        receitas[k].titulo = final.GetString(1);
                        receitas[k].ingrediente = final.GetString(2);
                        receitas[k].modo_preparo = final.GetString(3);
                    }

                    k += 1;
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

            CardReceita[] lista = new CardReceita[retorno.Count];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = new CardReceita();
                
                lista[i].Titulo = receitas[i].titulo;
                lista[i].Ingredientes = receitas[i].ingrediente;
                lista[i].Descricao = receitas[i].modo_preparo;

                flowLayoutPanel1.Controls.Add(lista[i]);
            }
        }

        private void RetornoReceitas_Load(object sender, EventArgs e)
        {
            var r = BuscarReceitas.instanciaBuscarReceitas.itens();

            retornaReceitas(r);
            GenerateDynamicUserControl();

            MessageBox.Show(" Receitas encontradas: " + retorno.Count);
        }

        private void cardReceita1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
