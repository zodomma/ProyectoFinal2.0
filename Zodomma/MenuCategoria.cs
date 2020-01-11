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
    public partial class MenuCategoria : Form
    {
        Categoria categoria = null;
        CategoriaLogica categoriaLogica = null;
        DataTable dttcategoria = null;
        string id;
        public MenuCategoria()
        {
            InitializeComponent();
            ListarCategorias();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCancelar.Enabled=false;
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id= dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells[2].Value.ToString();
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
            ListarCategorias();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCategoria();
            ListarCategorias();
            LimpiarCampos();
            botones();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarCategoria();
            ListarCategorias();
            botones();
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            botones();
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
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
                dgvCategoria.DataSource = dttcategoria;
            }
            else
            {
                MessageBox.Show("No hay categorias registradas");
            }

        }
        
        private void GuardarCategoria()
        {
            categoria = new Categoria();
            categoria.setNombre(txtNombre.Text);
            categoria.setDescripcion(txtDescripcion.Text);

            categoriaLogica = new CategoriaLogica(categoria);
            categoriaLogica.RegistrarCategoria();
            MessageBox.Show("Categoria guardada exitosamente");
        }

        private void ActualizarCategoria()
        {
            categoria = new Categoria();
            categoria.setId_categoria(int.Parse(id));
            categoria.setNombre(txtNombre.Text);
            categoria.setDescripcion(txtDescripcion.Text);
            categoriaLogica = new CategoriaLogica(categoria);
            categoriaLogica.ActualizarCategoria();
            MessageBox.Show("Categoria actualizada");
            ListarCategorias();
        }

        private void BorrarCategoria()
        {
            categoria = new Categoria();
            categoria.setId_categoria(int.Parse(id));

            categoriaLogica = new CategoriaLogica(categoria);
            categoriaLogica.EliminarCategoria();
            MessageBox.Show("categoria eliminada exitosamente");
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }

        private void botones()
        {
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sincaracteres(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sincaracteres(e);
        }

       
    }
}
    