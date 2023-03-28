using Domain;
using Entidad.Usuario.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAppLogin.Controllers
{
    public class UsuarioController : Controller
    {
        #region [Properties]
        private readonly UsuarioDomain oUsuarioDomain = null;
        #endregion

        #region [Constructor]
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuarioController()
        {
            oUsuarioDomain = new UsuarioDomain();
        }
        #endregion

        #region [ActionResult]
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region [Methods]
        [HttpGet]
        public ActionResult ValidateLogin(LoginRequest entidad)
        {
            var response = oUsuarioDomain.ValidateLogin(entidad);
            return Json(response);
        }
        #endregion
    }
}
