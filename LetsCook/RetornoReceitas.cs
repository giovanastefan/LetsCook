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

namespace LetsCook
{
    public partial class RetornoReceitas : Form
    {
        public RetornoReceitas()
        {
            InitializeComponent();
        }

        public void retornaReceitas(List<string> ingredientesReceita)
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT id, ingredientes from receitas";
                string[] itens = new string[10];
                List<string[]> total = new List<string[]>();
                List<int> retorno = new List<int>();


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
                int contem = 0;

                foreach (string[] i in total)
                {
                    contem = 0;
                    foreach (string j in i)
                    {
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

                    while (final.Read())
                    {
                        //adaptar para uma lista
                        MessageBox.Show(final["titulo"].ToString());
                    }
                    conexao.fecharConexao();
                }
            }
            catch
            {
                MessageBox.Show("Ops, algo deu errado, tente novamente!");
            }

        }

        private void RetornoReceitas_Load(object sender, EventArgs e)
        {
            var r = BuscarReceitas.instanciaBuscarReceitas.itens();

            retornaReceitas(r);
        }
    }
}
