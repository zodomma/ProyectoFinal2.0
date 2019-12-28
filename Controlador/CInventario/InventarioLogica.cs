using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.CInventario;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador.CInventario
{
    public class InventarioLogica
    {
        //se crea la instancia de la clase inventario pero solo parcialmente
        readonly Inventario inventario = null;

        //constructor

        public InventarioLogica(Inventario info)
        {
            this.inventario = info;
        }

        public void RegistrarProducto()
        {
            try
            {
                ClsDatos clsDatos = new ClsDatos();
                MySqlParameter[] parameters = new MySqlParameter[4];

                parameters[0] = new MySqlParameter();
                parameters[0].ParameterName = "_id_categoria";
                parameters[0].MySqlDbType = MySqlDbType.Int32;
                parameters[0].Value = inventario.getId_categoria();

                parameters[1] = new MySqlParameter();
                parameters[1].ParameterName = "_nombre";
                parameters[1].MySqlDbType = MySqlDbType.VarChar;
                parameters[1].Size = 20;
                parameters[1].Value = inventario.getNombre();

                parameters[2] = new MySqlParameter();
                parameters[2].ParameterName = "_precio";
                parameters[2].MySqlDbType = MySqlDbType.Int32;
                parameters[2].Value = inventario.getPrecio();

                parameters[3] = new MySqlParameter();
                parameters[3].ParameterName = "_cantidad";
                parameters[3].MySqlDbType = MySqlDbType.Int32;
                parameters[3].Value = inventario.getCantidad();

                clsDatos.EjecutarSP(parameters, "SPInsertarProducto");

            }catch(Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }

        public DataTable ListarProductos()
        {
            DataTable listarproductos;
            try
            {
                ClsDatos clsDatos = new ClsDatos();
                MySqlParameter[] parameters = null;
                listarproductos = clsDatos.RetornarTabla(parameters, "SPListarProductos");
            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
            return listarproductos;
        }

        public void ActulizarProducto()
        {
            try
            {
                ClsDatos clsDatos = new ClsDatos();

                MySqlParameter[] parameters = new MySqlParameter[5];

                parameters[0] = new MySqlParameter();
                parameters[0].ParameterName = "_id_producto";
                parameters[0].MySqlDbType = MySqlDbType.Int32;
                parameters[0].Value = inventario.getId_producto();

                parameters[1] = new MySqlParameter();
                parameters[1].ParameterName = "_id_categoria";
                parameters[1].MySqlDbType = MySqlDbType.Int32;
                parameters[1].Value = inventario.getId_categoria();

                parameters[2] = new MySqlParameter();
                parameters[2].ParameterName = "_nombre";
                parameters[2].MySqlDbType = MySqlDbType.VarChar;
                parameters[2].Size = 20;
                parameters[2].Value = inventario.getNombre();

                parameters[3] = new MySqlParameter();
                parameters[3].ParameterName = "_precio";
                parameters[3].MySqlDbType = MySqlDbType.Int32;
                parameters[3].Value = inventario.getPrecio();

                parameters[4] = new MySqlParameter();
                parameters[4].ParameterName = "_cantidad";
                parameters[4].MySqlDbType = MySqlDbType.Int32;
                parameters[4].Value = inventario.getCantidad();

                clsDatos.EjecutarSP(parameters, "SPActualizarProducto");
                

            }
            catch(Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }

        public void EliminarProducto()
        {
            try
            {
                ClsDatos clsDatos = new ClsDatos();
                MySqlParameter[] parameters = new MySqlParameter[1];

                parameters[0] = new MySqlParameter();
                parameters[0].ParameterName = "_id_producto";
                parameters[0].MySqlDbType = MySqlDbType.Int32;
                parameters[0].Value = inventario.getId_producto();

                clsDatos.EjecutarSP(parameters, "SPEliminarProducto");


            }catch(Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }
    }
}
