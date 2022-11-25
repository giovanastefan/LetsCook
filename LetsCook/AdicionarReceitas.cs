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
    public partial class AdicionarReceitas : Form
    {
        Classes.Receitas receitas = new Classes.Receitas();
        string ingredientes;
        public AdicionarReceitas()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtIngredientes.Clear();
            txtItem.Clear();
            txtPreparo.Clear();
            txtTitulo.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtTitulo.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItem.Text.Trim() != "")
            {
                receitas.adicionarIngrediente(txtItem.Text);
                if (txtIngredientes.Text == "")
                    txtIngredientes.Text = txtIngredientes.Text + "- " + txtItem.Text;
                else
                    txtIngredientes.Text = txtIngredientes.Text + "\n- " + txtItem.Text;
            }
            txtItem.Clear();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {

            ingredientes = receitas.converteParaString(receitas.Ingredientes);
            Conexao conexao = new Conexao();
            conexao.abrirConexao();

            try
            {

                string comando = "INSERT INTO receitas (titulo, ingredientes, modo_preparo) " +
                                     "VALUES (@titulo, @ingredientes, @modo_preparo)";

                conexao.consulta(comando);

                conexao.cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                conexao.cmd.Parameters.AddWithValue("@ingredientes", ingredientes);
                conexao.cmd.Parameters.AddWithValue("@modo_preparo", txtPreparo.Text);

                conexao.cmd.Prepare();

                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Receita salva com sucesso!",
                                 "Sucesso!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                limparCampos();
            }
            catch
            {
                MessageBox.Show("Algo deu errado, tente novamente!");
            }
            finally
            {
                conexao.fecharConexao();
            }
        }
    }
}
