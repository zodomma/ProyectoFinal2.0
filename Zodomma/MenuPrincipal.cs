using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows;

namespace Zodomma
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            loguin loguinn = new loguin();
            loguinn.Visible = false;
        }

        private void regsitrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarUsuarios registrarUsuarios = new RegistrarUsuarios();
            registrarUsuarios.Show();
        }

        //Boton crear cliente
        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = new Button();
            boton.Click += new EventHandler(btnCliente_Clicked);
            boton.Text = Interaction.InputBox("Ingrese nombrbre:");
            boton.Name = boton.Text;
            boton.Size = new Size(320, 27);
            flowLayoutPanel1.Controls.Add(boton);
           

        }

        private void btnCliente_Clicked(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            Button botton = sender as Button;
            cliente.Text = (botton.Name);
            

        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            int mesa;
            string mesaa;

            flowLayoutPanel2.Visible = false;

            for (mesa = 1; mesa <= 70; mesa++)
            {


                mesaa = mesa.ToString();
                flowLayoutPanel2.Controls.RemoveByKey(mesaa);

            }
            flowLayoutPanel2.Visible = true;


            for (mesa = 1; mesa <= 40; mesa++) {

                Button boton = new Button();
                boton.Click += new EventHandler(btn_Clicked);
               
                boton.Text = ("Mesa" + mesa);
                boton.Name = ("" + mesa);
                boton.Size = new Size(118, 122);
                flowLayoutPanel2.Controls.Add(boton);


            }

        }
        private void btn_Clicked(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();
            mesa.Show();
            Button botton = sender as Button;
            mesa.Text = (botton.Text);

        }

       

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int mesa;
            string mesaa;
            flowLayoutPanel2.Visible = false;
            for (mesa = 1; mesa <= 70; mesa++)
            {

                mesaa = mesa.ToString();
                flowLayoutPanel2.Controls.RemoveByKey(mesaa);

            }
            flowLayoutPanel2.Visible = true;

            for (mesa = 1; mesa <= 54; mesa++)
            {

                Button boton = new Button();
                boton.Click += new EventHandler(btn_Clicked);
                boton.Text = ("Mesa" + mesa);
                boton.Name = ("" + mesa);
                boton.Size = new Size(104, 102);
                flowLayoutPanel2.Controls.Add(boton);

            }

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int mesa;
            string mesaa;
            flowLayoutPanel2.Visible = false;
            for (mesa = 1; mesa <= 70; mesa++)
            {

                mesaa = mesa.ToString();
                flowLayoutPanel2.Controls.RemoveByKey(mesaa);

            }
            flowLayoutPanel2.Visible = true;

            for (mesa = 1; mesa <= 70; mesa++)
            {

                Button boton = new Button();
                boton.Click += new EventHandler(btn_Clicked);
                boton.Text = ("Mesa" + mesa);
                boton.Name = ("" + mesa);
                boton.Size = new Size(93, 86);
                flowLayoutPanel2.Controls.Add(boton);

            }
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuInventario menuInventario = new MenuInventario();
            menuInventario.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCategoria menuCategoria = new MenuCategoria();
            menuCategoria.Show();
        }
    }
}
