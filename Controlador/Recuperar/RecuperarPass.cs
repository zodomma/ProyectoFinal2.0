using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Recuperar
{
    public class RecuperarPass
    {
        private string user;
        private string respuest;
        private string pass;
        public string getUser()
        {
            return user;
        }
        public void setUser(string usu)
        {
            this.user = usu;
        }
        public string getRespuest()
        {
            return respuest;
        }
        public void setRespuest(string respues)
        {
            this.respuest = respues;
        }
        public string getPass()
        {
            return pass;
        }
        public void setPass(string password)
        {
            this.pass = password;
        }
    }
}
