using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador.Logueo;

namespace Zodomma
{
    public partial class loguin : Form
    {
        Loguin ingresar = null;
        LoguinLogica ingresarLoguica = null;

        public loguin()
        {
            InitializeComponent();
        }

        private void lblrecuperar_Enter(object sender, EventArgs e)
        {
            if(txtusuario.Text == "USUARIO") 
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void btnacceder_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA") 
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.LightGray;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablita = null;


                ingresar = new Loguin();
                ingresar.setUser(txtusuario.Text);
                ingresar.setPass(txtcontraseña.Text);

                ingresarLoguica = new LoguinLogica(ingresar);
                ingresarLoguica.ingresar();


                tablita = ingresarLoguica.ingresar();


                MenuPrincipal menuPrincipal = new MenuPrincipal();

                
                menuPrincipal.Show();
                this.Hide();
                
            }
            catch
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA");
            }
            




        }

        private void lblrecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar recuperar = new Recuperar();

            recuperar.Show();
        }

        private void loguin_Load(object sender, EventArgs e)
        {

        }
    }
}
