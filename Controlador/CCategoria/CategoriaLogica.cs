using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;

namespace Controlador.CCategoria
{
    public class CategoriaLogica
    {
        
        readonly Categoria categoria = null;

        public CategoriaLogica(Categoria dcategoria)
        {
            categoria = dcategoria;
        }

        public void RegistrarCategoria()
        {
            try
            {
                ClsDatos clsDatos = new ClsDatos();
                MySqlParameter[] parameter = new MySqlParameter[2];

                parameter[0] = new MySqlParameter();
                parameter[0].ParameterName = "_nombre";
                parameter[0].MySqlDbType = MySqlDbType.VarChar;
                parameter[0].Size = 20;
                parameter[0].Value = categoria.getNombre();

                parameter[1] = new MySqlParameter();
                parameter[1].ParameterName = "_Descripcion";
                parameter[1].MySqlDbType = MySqlDbType.VarChar;
                parameter[1].Size = 150;
                parameter[1].Value = categoria.getDescripcion();

                clsDatos.EjecutarSP(parameter, "SPRegistrarCategoria");

            }catch(Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }

        public DataTable ListarCategorias()
        {
            DataTable tablacategoria;
            try
            {
                ClsDatos clsDatos = new ClsDatos();
                MySqlParameter[] parameters = null;
                tablacategoria = clsDatos.RetornarTabla(parameters,"SPListarCategoria");
            }catch(Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }

            return tablacategoria;
        }

        public void ActualizarCategoria()
        {
            try
            {
                ClsDatos clsDatos = new ClsDatos();

                MySqlParameter[] parameters = new MySqlParameter[3];

                parameters[0] = new MySqlParameter();
                parameters[0].ParameterName = "_id_categoria";
                parameters[0].MySqlDbType = MySqlDbType.Int16;
                parameters[0].Value = categoria.getId_categoria();

                parameters[1] = new MySqlParameter();
                parameters[1].ParameterName = "_nombre";
                parameters[1].MySqlDbType = MySqlDbType.VarChar;
                parameters[1].Size = 20;
                parameters[1].Value = categoria.getNombre();

                parameters[2] = new MySqlParameter();
                parameters[2].ParameterName = "_Descripcion";
                parameters[2].MySqlDbType = MySqlDbType.VarChar;
                parameters[2].Size = 150;
                parameters[2].Value = categoria.getDescripcion();

                clsDatos.EjecutarSP(parameters, "SPActualizarCategoria");

            }catch(Exception e)
            {
                Exception exception = new Exception();
                throw exception;
            }
        }

        public void EliminarCategoria()
        {
            try
            {
                ClsDatos clsDatos = new ClsDatos();
                MySqlParameter[] parameters = new MySqlParameter[1];

                parameters[0] = new MySqlParameter();
                parameters[0].ParameterName = "_id_categoria";
                parameters[0].MySqlDbType = MySqlDbType.Int16;
                parameters[0].Value = categoria.getId_categoria();

                clsDatos.EjecutarSP(parameters, "SPEliminarCategoria");

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }

    }
}
