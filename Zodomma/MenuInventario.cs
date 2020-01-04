using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Controlador.CInventario;
using Controlador.CCategoria;

namespace Zodomma
{
    public partial class MenuInventario : Form
    {
        Inventario inventario = null;
        InventarioLogica inventarioLogica = null;
        Categoria categoria = null;
        CategoriaLogica categoriaLogica = null;
        
        DataTable dtproductos = null;
        DataTable dtcategoria = null;
        public MenuInventario()
        {
            InitializeComponent();
            listarProductos();
            ListarCategoria();
            cbcategoria.SelectedIndex = 0;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void MenuInventario_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            listarProductos();
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarProducto();
            listarProductos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            LimpiarCampos();
            listarProductos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void listarProductos()
        {
            inventario = new Inventario();
            inventarioLogica = new InventarioLogica(inventario);
            dtproductos = inventarioLogica.ListarProductos();
            if (dtproductos.Rows.Count > 0)
            {
                dgvproductos.DataSource = dtproductos;
            }
            else
            {
                MessageBox.Show("No hay productos registrados");
            }

        }

        private void ListarCategoria()
        {
            categoria = new Categoria();
            categoriaLogica = new CategoriaLogica(categoria);
            dtcategoria = categoriaLogica.ListarCategorias();
            if (dtcategoria.Rows.Count > 0)
            {
                cbcategoria.DataSource = dtcategoria;
                DataRow data = dtcategoria.NewRow();
                data["nombre"] = "Seleccione";
                dtcategoria.Rows.InsertAt(data, 0);
                cbcategoria.DisplayMember = "nombre";
                cbcategoria.ValueMember = "id_categoria";
            }
        }

        private void RegistrarProducto()
        {
            //condicional para validar que elijan una categoria antes de registrar un producto
            if (cbcategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Elija una categoria");
            }
            else
            {
                inventario = new Inventario();
                inventario.setNombre(txtnombre.Text);
                inventario.setPrecio(int.Parse(txtprecio.Text));
                inventario.setCantidad(int.Parse(txtcantidad.Text));
                inventario.setId_categoria(cbcategoria.SelectedIndex);
                inventarioLogica = new InventarioLogica(inventario);
                inventarioLogica.RegistrarProducto();

                MessageBox.Show("Producto registrado");
            }
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtnombre.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            cbcategoria.SelectedIndex = 0;
            txtcodigo.Visible = false;
            lblcodigo.Visible = false;

        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Visible = true;
            lblcodigo.Visible = true;
            txtcodigo.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombre.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[1].Value.ToString();
            txtcantidad.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[2].Value.ToString();
            txtprecio.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[3].Value.ToString();
            cbcategoria.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[4].Value.ToString();
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void Actualizar()
        {
            inventario = new Inventario();
            inventario.setId_producto(int.Parse(txtcodigo.Text));
            inventario.setNombre(txtnombre.Text);
            inventario.setCantidad(int.Parse(txtcantidad.Text));
            inventario.setPrecio(int.Parse(txtprecio.Text));
            inventario.setId_categoria(cbcategoria.SelectedIndex);

            inventarioLogica = new InventarioLogica(inventario);
            inventarioLogica.ActulizarProducto();
            MessageBox.Show("Producto actualizado");
        }

        private void Eliminar()
        {
            inventario = new Inventario();
            inventario.setId_producto(int.Parse(txtcodigo.Text));

            inventarioLogica = new InventarioLogica(inventario);
            inventarioLogica.EliminarProducto();
            MessageBox.Show("Producto eliminado");

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sincaracteres(e);
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }
    }
}
