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
        private int id;
        private string name;
        private string user;
        private string password;

        public string getUser()
        {
            return user;
        }

        public void setUser(string user)
        {
            this.user = user;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = user;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }


    }
}
