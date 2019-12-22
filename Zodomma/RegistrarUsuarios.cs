using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador.RregistroUser;
namespace Zodomma
{
    public partial class RegistrarUsuarios : Form
    {
        RegistroUsuario registros = null;
        RegistroUsuarioLogica registrosLogica = null;
        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text==txtRcontraseña.Text) {
                lblMensaje.Visible = false;
                registros = new RegistroUsuario();
                registros.setUsuario(txtUsuario.Text);
                registros.setPasword(txtContraseña.Text);
                registros.setPregunta(cbPregunta.Text);
                registros.setRespuesta(txtRespuesta.Text);
                registros.setTipo(2);

                registrosLogica = new RegistroUsuarioLogica(registros);
                registrosLogica.registrarUsuario();
                MessageBox.Show("usuario registrado correctamente");
            }
            else
            {
                lblMensaje.Text = "la contraeña no coincide";
                lblMensaje.Visible = true;
            }
                
        }
    }
}
