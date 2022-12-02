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
    public partial class CardReceitas : UserControl
    {
        public CardReceitas()
        {
            InitializeComponent();
        }
        public void Title(string a)
        {
            lblTitulo.Text = a;
        }
    }
}
