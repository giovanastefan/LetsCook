using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LetsCook
{
    internal class Usuario
    {
        private string user;
        private string password;

        public string getUser()
        {
            return user;
        }

        public string getPassword()
        {
            return password;
        }

        // validar se será possivel o usuario alterar seu user e senha
        public void setUser(string user)
        {
            this.user = user;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
