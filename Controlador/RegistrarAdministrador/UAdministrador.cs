namespace Controlador.RegistrarAdministrador
{
    public class UAdministrador
    {
        //asi se hacen los metodos get y set en c# no se acostumbren a este metodo
        public string usuario { get; set; }
        public string contra { get; set; }
        public string pregunta { get; set; }
        public string respuesta { get; set; }


        //asi se hacen el get y set en la mayoria de los lenguajes de programacion
        //les recomiento los practiquen

        private int tipousuario;

        public int getTipousuario()
        {
            return tipousuario;
        }

        public void setTipousuario(int valor)
        {
            this.tipousuario = valor;
        }

    }
}
