using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Controlador.RregistroUser
{
    public class RegistroUsuarioLogica
    {
        ClsDatos ClsDatos = null;
        readonly RegistroUsuario registroUsuario = null;
        
        public RegistroUsuarioLogica(RegistroUsuario registrousuario)
        {
            registroUsuario = registrousuario;
        }

        public void registrarUsuario()
        {
            try
            {
                ClsDatos = new ClsDatos();
                MySqlParameter[] parameters = new MySqlParameter[5];

                parameters[0] = new MySqlParameter();
                parameters[0].ParameterName = "_USUARIO";
                parameters[0].MySqlDbType = MySqlDbType.VarChar;
                parameters[0].Size = 30;
                parameters[0].Value = registroUsuario.getUsuario();

                parameters[1] = new MySqlParameter();
                parameters[1].ParameterName = "_CONTRA";
                parameters[1].MySqlDbType = MySqlDbType.VarChar;
                parameters[1].Size = 100;
                parameters[1].Value = registroUsuario.getPassword();

                parameters[2] = new MySqlParameter();
                parameters[2].ParameterName = "_PREGUNTA";
                parameters[2].MySqlDbType = MySqlDbType.VarChar;
                parameters[2].Size = 50;
                parameters[2].Value = registroUsuario.getPregunta();

                parameters[3] = new MySqlParameter();
                parameters[3].ParameterName = "_RESPUESTA";
                parameters[3].MySqlDbType = MySqlDbType.VarChar;
                parameters[3].Size = 50;
                parameters[3].Value = registroUsuario.getRespuesta();

                parameters[4] = new MySqlParameter();
                parameters[4].ParameterName = "_TIPO";
                parameters[4].MySqlDbType = MySqlDbType.Int16;
                parameters[4].Value = registroUsuario.getTipo();

                ClsDatos.EjecutarSP(parameters, "SPRegistrarUsuario");
            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                    throw exception;
            }
        }
      
      
    }
}
