using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Logueo
{
    public class Loguin
    {
        private string user;
        private string pass;

        public string getUser()
        {
            return user;
        }

        public void setUser(string usuario)
        {
            this.user = usuario;
        }

        public string getPass()
        {
            return pass;
        }

        public void setPass(string contraseña)
        {
            this.pass = contraseña;
        }
    }
}
