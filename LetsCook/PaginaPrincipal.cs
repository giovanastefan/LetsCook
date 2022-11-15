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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            childPanel.Controls.Clear();
            BuscarReceitas janela = new BuscarReceitas();
            janela.TopLevel = false;
            janela.Visible = true;
            childPanel.Controls.Add(janela);
        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            childPanel.Controls.Clear();
            AdicionarReceitas janela = new AdicionarReceitas();
            janela.TopLevel = false;
            janela.Visible = true;
            childPanel.Controls.Add(janela);
        }
    }
}
