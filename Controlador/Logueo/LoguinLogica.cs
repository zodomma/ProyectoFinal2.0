using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;

namespace Controlador.Logueo
{
    public class LoguinLogica
    {
        ClsDatos clsDatos = null;
        readonly Loguin loguin = null;
        DataTable Table = null;

        public LoguinLogica(Loguin logueo)
        {
            loguin = logueo;
        }

        public DataTable ingresar()
        {
            try
            {
                clsDatos = new ClsDatos();
                MySqlParameter[] parameter = new MySqlParameter[2];

                parameter[0] = new MySqlParameter();
                parameter[0].ParameterName = "_usuario";
                parameter[0].MySqlDbType = MySqlDbType.VarChar;
                parameter[0].Size = 30;
                parameter[0].Value = loguin.getUser();

                parameter[1] = new MySqlParameter();
                parameter[1].ParameterName = "_pass";
                parameter[1].MySqlDbType = MySqlDbType.VarChar;
                parameter[1].Size = 100;
                parameter[1].Value = loguin.getPass();

                Table=clsDatos.RetornarTabla(parameter, "SPLoguin");

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
            return Table;
        }

        

    }
}
