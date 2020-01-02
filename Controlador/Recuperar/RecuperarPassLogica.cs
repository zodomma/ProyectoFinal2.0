using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Controlador.Recuperar
{
    public class RecuperarPassLogica
    {
        ClsDatos clsDatos = null;
        readonly RecuperarPass recuperarPass = null;

        public RecuperarPassLogica(RecuperarPass recuperarpass)
        {
            recuperarPass = recuperarpass;
        }

        public void recuperarPassword()
        {
            try
            {


                clsDatos = new ClsDatos();
                MySqlParameter[] parameter = new MySqlParameter[3];

                parameter[0] = new MySqlParameter();
                parameter[0].ParameterName = "_usuario";
                parameter[0].MySqlDbType = MySqlDbType.VarChar;
                parameter[0].Size = 30;
                parameter[0].Value = recuperarPass.getUser();

                parameter[1] = new MySqlParameter();
                parameter[1].ParameterName = "_respuesta";
                parameter[1].MySqlDbType = MySqlDbType.VarChar;
                parameter[1].Size = 50;
                parameter[1].Value = recuperarPass.getRespuest();

                parameter[2] = new MySqlParameter();
                parameter[2].ParameterName = "_pass";
                parameter[2].MySqlDbType = MySqlDbType.VarChar;
                parameter[2].Size = 100;
                parameter[2].Value = recuperarPass.getPass();

                clsDatos.EjecutarSP(parameter, "SPRecuperar");
            }catch(Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }

    }
}
