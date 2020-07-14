using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarritoVersion95.Data;
using CarritoVersion95.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarritoVersion95.Controllers
{
    public class LoginController : Controller
    {

        const string sesion = "MiSesion";


            private readonly ApplicationDbContext _context;
            
            public LoginController(ApplicationDbContext servicioInyectado)
            {
                _context = servicioInyectado;
            }

            [HttpGet]
        public IActionResult Registrarse()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Registrarse(Usuario usuario)
        {


            //Verificamos que el email ya no este en uso
            if (ModelState.IsValid)
            {
                //var user = _context.Usuarios.SingleOrDefaultAsync(u => u.email == usuario.email);
                var user = _context.Usuarios.Where(u => u.email == usuario.email).FirstOrDefault();

                if (user != null)
                {
                    ModelState.AddModelError("email", "Este email ya está registrado");
                    return View();
                }
            }             



            //Acá registramos a los usuarios en la base de datos.
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                _context.SaveChanges();

                //Iniciamos una sesion en el nav del usuario
                var IdUsuario = usuario.IdUsuario;
                HttpContext.Session.SetString(sesion, IdUsuario.ToString());

                //Mandamos el usuario a MiPanel
                return RedirectToAction("MiPanel", "Panel");
            }
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Login()
        {
        return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(Usuario usuario)
        {
            //Acá logueamos.
            //var UsuarioX = _context.Usuarios.Where(u => u.contrasenia == usuario.contrasenia && u.email == usuario.email);

            var user = await _context.Usuarios.SingleOrDefaultAsync(u => u.contrasenia == usuario.contrasenia && u.email == usuario.email);
            if (user == null)
            {
                //ModelState.AddModelError("Password", "Invalid login attempt.");
                return RedirectToAction("Login", "Login");
            }

            var IdUsuario = user.IdUsuario;
            HttpContext.Session.SetString(sesion, IdUsuario.ToString());



            // Verifico que haya una sesion activa, si hay envio un mensaje para habilitar el boton finalizar compra
            var numeroenstring = HttpContext.Session.GetString("MiSesion");
            if (numeroenstring != null)
            {
                ViewBag.MsjErrorLoginNecesario = null;
            }


            return RedirectToAction("MiPanel", "Panel");
     
        }
    }
}
