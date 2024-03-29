﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsCook
{
    public partial class ReceitasFavoritas : Form
    {
        public ReceitasFavoritas()
        {
            InitializeComponent();
        }

        private void ReceitasFavoritas_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            try
            {
                conexao.abrirConexao();

                string comando = "select receitas.titulo, receitas.ingredientes, receitas.modo_preparo from receitas INNER JOIN receitas_favoritas ON receitas.id = receitas_favoritas.cod_receita INNER JOIN usuario on usuario.id = receitas_favoritas.cod_usuario where usuario.id = " + formInicial.instanciaLogin.getId() + "";

                DataTable dtb = new DataTable();
                MySqlDataAdapter sqlData = new MySqlDataAdapter(conexao.consulta(comando));

                sqlData.Fill(dtb);

                dataGridView1.DataSource = dtb;

                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 300;
                dataGridView1.Columns[2].Width = 345;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado, tente novamente mais tarde!");
            }
            finally
            {
                conexao.fecharConexao();
            }
        }
    }
}
