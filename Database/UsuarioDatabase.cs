using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    /// <summary>
    /// Clase usuario database
    /// </summary>
    public class UsuarioDatabase
    {
        #region [Properties]

        #endregion

        #region [Constructor]
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuarioDatabase()
        {

        }
        #endregion

        #region [Methods]
        /// <summary>
        /// El método valida el usuario y contraseña
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public bool ValidateLogin(string pUser, string pPassword )
        {
            bool isValid = false;

            if (pUser!= null && pPassword != null)
                isValid = true;

            return isValid;
        }

        #endregion
    }
}
