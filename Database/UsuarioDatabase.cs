using Dapper;
using Database.Configuracion;
using Entidad.Usuario.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Database
{
    /// <summary>
    /// Clase usuario database
    /// </summary>
    public class UsuarioDatabase
    {
        #region [Properties]
        private readonly Conexion connection = null;
        #endregion

        #region [Constructor]
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuarioDatabase()
        {
            connection = new Conexion();
        }
        #endregion

        #region [Methods]
        /// <summary>
        /// El método valida el usuario y contraseña
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public List<string> ValidateLogin(LoginRequest entidad )
        {
            using (var cn = connection.GetConnectionSeguridad)
            {

                #region [Query]
                const string query = @"SELECT usu.Id
                                           FROM Usuarios usu";
                #endregion

                #region [Parameters]
                //var parameters = new DynamicParameters();
                //parameters.Add("@pUser", entidad.User, DbType.String);
                //parameters.Add("@pPassword", entidad.Password, DbType.String);
                #endregion

                #region [Execute]
                var response =  cn.Query<string>(query, commandType: CommandType.Text);
                //var response = cn.Query<string>(query, commandType: CommandType.StoredProcedure);
                return response.ToList();
                #endregion

            }
        }
        #endregion
    }
}
