using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.CCategoria
{
    public class Categoria
    {
        private string nombre;
        private string descripcion;
        private int id_categoria;

        public void setNombre(string valor)
        {
            this.nombre = valor;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setDescripcion(string valor)
        {
            this.descripcion = valor;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public void setId_categoria(int valor)
        {
            this.id_categoria = valor;
        }

        public int getId_categoria()
        {
            return this.id_categoria;
        }
    }
}
