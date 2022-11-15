using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCook
{
    internal class Receitas
    {
        public List<string> Ingredientes = new List<string>();
   
        public Receitas() { }

        public void adicionarIngrediente(string ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }

    }
}
