﻿using Database;
using Entidad.Usuario.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UsuarioDomain
    {
        #region [Properties]
        private readonly UsuarioDatabase oUsuarioDatabase = null;//new UsuarioDatabase();
        #endregion

        #region [Constructor]
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuarioDomain()
        {
            oUsuarioDatabase = new UsuarioDatabase();
        }
        #endregion

        #region [Methods]
        /// <summary>
        /// El método valida el usuario y contraseña
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public List<string> ValidateLogin(LoginRequest entidad)
        {
            List<string> listResponse = null;

            try
            {
                var response = oUsuarioDatabase.ValidateLogin(entidad);
                listResponse = response;
            }
            catch (Exception e)
            {
                 e.Message.ToString();
            }
            return listResponse;
        }
        #endregion
    }
}
