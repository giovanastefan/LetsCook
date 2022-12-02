using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsCook
{
    public partial class ListaReceitas : UserControl
    {
        Receitas receita;
        public ListaReceitas()
        {
            InitializeComponent();
        }

        public void r()
        {
            lblTitulo.Text = "ok";
        }
    }
}
