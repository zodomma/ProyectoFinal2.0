using Controlador.RegistrarAdministrador;
using System;
using System.Windows.Forms;

namespace Zodomma
{
    public partial class Form1 : Form
    {
        UAdministrador administrador = null;
        UAdministradorLogica administradorLogica = null;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnregistrar_Click(object sender, EventArgs e)
        {
            administrador = new UAdministrador();
            administrador.usuario = txtusuario.Text;
            administrador.contra = txtcontraseña.Text;
            administrador.pregunta = cbpregunta.Text;
            administrador.respuesta = txtrespuesta.Text;
            administrador.setTipousuario(1);

            administradorLogica = new UAdministradorLogica(administrador);
            administradorLogica.registrarAdministrador();
            MessageBox.Show("Administrador registrado satisfactoriamente");
        }


    }
}
