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

        private string _titulo;
        private string _ingredientes;
        private string _descricao;

       
        [Category("Custom Props")]
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; labelTitulo.Text = value; }
        }

        [Category("Custom Props")]
        public string Ingredientes
        {
            get { return _ingredientes; }
            set { _ingredientes = value; labelIngredientes.Text = value; }
        }

        [Category("Custom Props")]
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; richTextBox1.Text = value; }
        }
    }
}

