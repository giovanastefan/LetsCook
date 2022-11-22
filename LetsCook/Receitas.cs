using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCook
{
    internal class Receitas
    {
        public int id; //verificar se esse campo pode ser publico
        public List<string> Ingredientes = new List<string>(); //verificar se esse campo pode ser publico

        public Receitas() { }

        public void adicionarIngrediente(string ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }

        public string converteParaString(List<string> itens)
        {
            itens.Sort();
            string stringFinal = "";
            foreach(string item in itens) {
                if (stringFinal == "")
                    stringFinal = stringFinal + item.ToLower();
                else
                    stringFinal = stringFinal + " " + item.ToLower();
            }

            return stringFinal;
        }

    }
}
