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
    public partial class CardReceita : UserControl
    {
        public CardReceita()
        {
            InitializeComponent();
        }

        private string titulo;

        [Category ("Custom Props")]
        public string Title
        {
            get { return titulo; }
            set { titulo = value; labelTitulo.Text = value; }
        }
    }
}
