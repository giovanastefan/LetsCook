﻿using System;
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
    public partial class Cadastro : Form
    {            
        public Cadastro()
        {
            InitializeComponent();

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_StyleChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtSenha.PasswordChar = '*';
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
