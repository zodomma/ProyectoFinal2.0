using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador.Recuperar;

namespace Zodomma
{
    public partial class Recuperar : Form
    {

        RecuperarPass recuperarPass = null;
        RecuperarPassLogica recuperarPassLogica = null;
        public Recuperar()
        {
            InitializeComponent();
        }

        private void btnrecuperar_Click(object sender, EventArgs e)
        {
            recuperarPass = new RecuperarPass();
            recuperarPass.setUser(txtusuario.Text);
            recuperarPass.setRespuest(txtrespuesta.Text);
            recuperarPass.setPass(txtcontra1.Text);

            recuperarPassLogica = new RecuperarPassLogica(recuperarPass);
            recuperarPassLogica.recuperarPassword();
            MessageBox.Show("se cambio la contraseña");
        }
    }
}
