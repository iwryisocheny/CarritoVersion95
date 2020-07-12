using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarritoVersion95.Models;
using Microsoft.AspNetCore.Http;
using CarritoVersion95.Data;

namespace CarritoVersion95.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext servicioInyectado)
        {
            _logger = logger;
            _context = servicioInyectado;
        }

        public IActionResult Index()
        {
            //var numeroenstring = HttpContext.Session.GetString("MiSesion");
            //if (numeroenstring != null)
            //{
            //    var idSesion = int.Parse(numeroenstring);
            //    Usuario usuario = _context.Usuarios.Find(idSesion);
            //    var emailusuario = usuario.email;
            //    ViewBag.emailusuario = emailusuario;
            //}
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
    }
}
