using Google.Protobuf.WellKnownTypes;
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

        public void limparFontes()
        {
            btnHome.Font = new Font(btnHome.Font, FontStyle.Regular);
            btnBuscar.Font = new Font(btnBuscar.Font, FontStyle.Regular);
            btnAdicionarReceita.Font = new Font(btnAdicionarReceita.Font, FontStyle.Regular);
        }

        public void limparPanel()
        {
            limparFontes();
            childPanel.Controls.Clear();
        }

        public void alterarPanel(Form janela)
        {
            janela.TopLevel = false;
            janela.Visible = true;
            childPanel.Controls.Add(janela);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limparPanel();
            BuscarReceitas janela = new BuscarReceitas();
            btnBuscar.Font = new Font(btnBuscar.Font, FontStyle.Bold);
            janela.TopLevel = false;
            janela.Visible = true;
            childPanel.Controls.Add(janela);
        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            limparPanel();
            AdicionarReceitas janela = new AdicionarReceitas();
            btnAdicionarReceita.Font = new Font(btnAdicionarReceita.Font, FontStyle.Bold);
            janela.TopLevel = false;
            janela.Visible = true;
            childPanel.Controls.Add(janela);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            limparPanel();
            btnHome.Font = new Font(btnHome.Font, FontStyle.Bold);
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void childPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
