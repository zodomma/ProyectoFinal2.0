namespace Controlador.RregistroUser
{
    public class RegistroUsuario
    {
        private string usuario;
        private string password;
        private string pregunta;
        private string respuesta;
        private int tipo;

        public string getUsuario()
        {
            return usuario;
        }

        public void setUsuario(string user)
        {
            this.usuario = user;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPasword(string pass)
        {
            this.password = pass;
        }
        public string getPregunta()
        {
            return pregunta;
        }

        public void setPregunta(string pregun)
        {
            this.pregunta = pregun;
        }

        public string getRespuesta()
        {
            return respuesta;
        }

        public void setRespuesta(string respues)
        {
            this.respuesta = respues;
        }

        public int getTipo()
        {
            return tipo;
        }

        public void setTipo(int valor)
        {
            this.tipo = valor;
        }

    }
}
