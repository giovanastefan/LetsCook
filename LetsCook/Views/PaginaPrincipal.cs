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
        public static PaginaPrincipal fontes;
        public PaginaPrincipal()
        {
            InitializeComponent();

            fontes = this;
        }

        public void limparFontes()
        {
            btnHome.Font = new Font(btnHome.Font, FontStyle.Regular);
            btnBuscar.Font = new Font(btnBuscar.Font, FontStyle.Regular);
            btnAdicionarReceita.Font = new Font(btnAdicionarReceita.Font, FontStyle.Regular);
            btnReceitasFavoritas.Font = new Font(btnReceitasFavoritas.Font, FontStyle.Regular);
            btnReceitas.Font = new Font(btnReceitas.Font, FontStyle.Regular);
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
            alterarPanel(janela);
        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            limparPanel();
            AdicionarReceitas janela = new AdicionarReceitas();
            btnAdicionarReceita.Font = new Font(btnAdicionarReceita.Font, FontStyle.Bold);
            alterarPanel(janela);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            limparPanel();
            HomePage janela = new HomePage();
            btnHome.Font = new Font(btnHome.Font, FontStyle.Bold);
            alterarPanel(janela);
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            limparPanel();
            HomePage janela = new HomePage();
            btnHome.Font = new Font(btnHome.Font, FontStyle.Bold);
            alterarPanel(janela);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInicial telaInical = new formInicial();
            telaInical.Show();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            limparPanel();
            BuscaReceitasGeral janela = new BuscaReceitasGeral();
            btnReceitas.Font = new Font(btnHome.Font, FontStyle.Bold);
            alterarPanel(janela);
        }

        private void btnReceitasFavoritas_Click(object sender, EventArgs e)
        {
            limparPanel();
            ReceitasFavoritas janela = new ReceitasFavoritas();
            btnReceitasFavoritas.Font = new Font(btnHome.Font, FontStyle.Bold);
            alterarPanel(janela);
        }
    }
}
