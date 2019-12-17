using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ClsDatos
    {
        #region Declaracion de variables

        /*se declaran todas las variables que van a ser necesarias para 
        la conexion a la base de datos */

        MySqlConnection sqlConnection = null;
        MySqlCommand sqlCommand = null;
        MySqlDataAdapter dataAdapter = null;
        DataTable dataTable = null;
        readonly String CadenaConexion = string.Empty;
        #endregion

        #region Constructor
        public ClsDatos()
        {
            CadenaConexion = "Server=localhost;Database=zodomma;Uid=root;Pwd=";
        }
        #endregion

        #region Metodos
        /*Metodos usados para ejecutar los procedimientos almacenados y 
          las diferentes colsultas a la base de datos*/

        //SP significa store procedure = procedimiento almacenado
        /*EjecutarSP es el metodo encargado de ejecutar los procedimientos
          almacenados en la base de datos*/
        public void EjecutarSP(MySqlParameter[] parameters, string procedimiento)
        {
            try
            {
                //Aqui se terminan todas las instancias de las variables
                //previamente declaradas para completar la conexion
                sqlConnection = new MySqlConnection(CadenaConexion);
                sqlCommand = new MySqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = procedimiento;
                sqlCommand.Parameters.AddRange(parameters);
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
            finally
            {
                sqlConnection.Dispose();
                sqlCommand.Dispose();
            }
        }

        public DataTable RetornarTabla(MySqlParameter[] parameters,string procedimiento)
        {
            try
            {
                //Aqui se terminan todas las instancias de las variables
                //previamente declaradas para completar la conexion
                dataTable = new DataTable();
                sqlConnection = new MySqlConnection(CadenaConexion);
                sqlCommand = new MySqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = procedimiento;
                if(parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }

                dataAdapter = new MySqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
            finally
            {
                sqlConnection.Dispose();
                sqlCommand.Dispose();
                dataAdapter.Dispose();
            }
            return dataTable;
        }


        #endregion

    }
}
