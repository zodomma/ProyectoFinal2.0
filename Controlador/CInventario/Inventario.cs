using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.CInventario
{
    public class Inventario
    {
        private int id_producto;
        private int id_categoria;
        private string nombre;
        private int precio;
        private int cantidad;

        public void setId_producto(int valor)
        {
            this.id_producto = valor;
        }

        public int getId_producto()
        {
            return this.id_producto;
        }

        public void setId_categoria(int valor)
        {
            this.id_categoria = valor;
        }

        public int getId_categoria()
        {
            return this.id_categoria;
        }

        public void setNombre(string texto)
        {
            this.nombre = texto;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setPrecio(int valor)
        {
            this.precio = valor;
        }

        public int getPrecio()
        {
            return this.precio;
        }

        public void setCantidad(int valor)
        {
            this.cantidad = valor;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }
    }
}
