using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarritoVersion95.Controllers
{
    public class PanelController : Controller
    {
        [HttpGet]
        public IActionResult MiPanel()
        {
            //Verificar si esta logueado, sino, mano a login
            var numeroenstring = HttpContext.Session.GetString("MiSesion");
            if (numeroenstring == null)
            {
                return RedirectToAction("Login", "Login");
            }

            return View();
        }
    }
}
