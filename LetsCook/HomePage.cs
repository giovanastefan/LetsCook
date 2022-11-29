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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            BuscaReceitasGeral r = new BuscaReceitasGeral();
            this.Hide();

            PaginaPrincipal.fontes.limparPanel();
            PaginaPrincipal.fontes.alterarPanel(r);
        }
    }
}
