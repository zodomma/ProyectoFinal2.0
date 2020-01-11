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

namespace Zodomma
{
    public partial class Mesa : Form
    {
        Categoria categoria = null;
        CategoriaLogica categoriaLogica = null;
        DataTable dttcategoria = null;
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
                clcategoria.DataSource = dttcategoria;
            }
            else
            {
                MessageBox.Show("No hay categorias registradas");
            }
        }
    }
}
