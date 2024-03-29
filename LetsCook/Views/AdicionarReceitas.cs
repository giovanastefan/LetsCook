﻿using LetsCook.Classes;
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
    public partial class AdicionarReceitas : Form
    {
        Receitas receitas = new Receitas();
        string ingredientes;
        int cod_categoria;
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

        private void retorna_categoria()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.abrirConexao();

                string comando = "SELECT * FROM categoria";

                conexao.consulta(comando);

                MySqlDataReader final = conexao.cmd.ExecuteReader();

                while (final.Read())
                {
                    comboBoxCategoria.Items.Add(final["descricao_categoria"].ToString());
                }

                conexao.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Erro!");
            }

        }

        private void selecao_comboBox()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.abrirConexao();
                var comboBox = comboBoxCategoria.SelectedItem.ToString();

                string comando = "SELECT idcategoria FROM categoria where descricao_categoria = @descricao";

                conexao.consulta(comando);

                conexao.cmd.Parameters.AddWithValue("@descricao", comboBox);

                MySqlDataReader final = conexao.cmd.ExecuteReader();

                while (final.Read())
                {
                    cod_categoria = Convert.ToInt32(final["idcategoria"]);
                }

                conexao.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Erro!");
            }
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
            selecao_comboBox();
            conexao.abrirConexao();

            try
            {
                string comando = "INSERT INTO receitas (titulo, ingredientes, modo_preparo, cod_categoria) " +
                                     "VALUES (@titulo, @ingredientes, @modo_preparo, @cod_categoria)";

                conexao.consulta(comando);

                conexao.cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                conexao.cmd.Parameters.AddWithValue("@ingredientes", ingredientes);
                conexao.cmd.Parameters.AddWithValue("@modo_preparo", txtPreparo.Text);
                conexao.cmd.Parameters.AddWithValue("@cod_categoria", cod_categoria);

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

        private void AdicionarReceitas_Load(object sender, EventArgs e)
        {
            retorna_categoria();
        }

    }
}
