using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Controlador.RegistrarAdministrador
{
    public class UAdministradorLogica
    {
        ClsDatos clsDatos = null;
        readonly UAdministrador uAdministrador = null;
        DataTable table = null;

        public UAdministradorLogica(UAdministrador uadministrador)
        {
            uAdministrador = uadministrador;
        }

        public void registrarAdministrador()
        {
            try
            {
                clsDatos = new ClsDatos();
                MySqlParameter[] parameters = new MySqlParameter[5];

                parameters[0] = new MySqlParameter();
                parameters[0].ParameterName = "_usuario";
                parameters[0].MySqlDbType = MySqlDbType.VarChar;
                parameters[0].Size = 30;
                parameters[0].Value = uAdministrador.usuario;

                parameters[1] = new MySqlParameter();
                parameters[1].ParameterName = "_contra";
                parameters[1].MySqlDbType = MySqlDbType.VarChar;
                parameters[1].Size = 100;
                parameters[1].Value = uAdministrador.contra;

                parameters[2] = new MySqlParameter();
                parameters[2].ParameterName = "_pregunta";
                parameters[2].MySqlDbType = MySqlDbType.VarChar;
                parameters[2].Size = 50;
                parameters[2].Value = uAdministrador.pregunta;

                parameters[3] = new MySqlParameter();
                parameters[3].ParameterName = "_respuesta";
                parameters[3].MySqlDbType = MySqlDbType.VarChar;
                parameters[3].Size = 50;
                parameters[3].Value = uAdministrador.respuesta;

                parameters[4] = new MySqlParameter();
                parameters[4].ParameterName = "_tusuario";
                parameters[4].MySqlDbType = MySqlDbType.Int16;
                parameters[4].Value = uAdministrador.getTipousuario();

                clsDatos.EjecutarSP(parameters, "SPRegistrarAdmin");

            }catch(Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }
    }
}
