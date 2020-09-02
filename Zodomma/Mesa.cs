using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador.CCategoria;
using Controlador.CInventario;

namespace Zodomma
{
    public partial class Mesa : Form
    {
        Categoria categoria = null;
        CategoriaLogica categoriaLogica = null;
        DataTable dttcategoria = null;

        Inventario inventario = null;
        InventarioLogica InventarioLogica = null;
        DataTable dttinventario = null;
       
        public Mesa()
        {
            InitializeComponent();
            ListarCategorias();
        }

        private void btnanadir_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void ListarCategorias()
        {
            categoria = new Categoria();
            categoriaLogica = new CategoriaLogica(categoria);

            dttcategoria = categoriaLogica.ListarCategorias();

            if (dttcategoria.Rows.Count > 0)
            {
                int cantidadC = dttcategoria.Rows.Count;
                
                for (int i = 0; i < cantidadC; i++)
                {
                    lbCategoria.Items.Add(dttcategoria.Rows[i][1].ToString());
                }
                
            }
            else
            {
                MessageBox.Show("No hay categorias registradas");
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {

        }

        private void Mesa_Load(object sender, EventArgs e)
        {

        }

        private void lbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventario = new Inventario();
            InventarioLogica = new InventarioLogica(inventario);

            dttinventario = InventarioLogica.ListarProductos();
            if (dttinventario.Rows.Count > 0)
            {
                int cantidadC = dttinventario.Rows.Count;

                for (int i = 0; i < cantidadC; i++)
                {
                    //if (dttcategoria.Rows[i][0] == dttinventario.Rows[i][0]) {
                        lbProductos.Items.Add(dttinventario.Rows[i][1].ToString());
                    //}
                }

            }
            else
            {
                MessageBox.Show("No hay categorias registradas");
            }

        }
    }
}
