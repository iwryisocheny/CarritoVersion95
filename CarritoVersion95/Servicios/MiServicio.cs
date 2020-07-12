using CarritoVersion95.Data;
using CarritoVersion95.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarritoVersion95.Servicios
{
    public class MiServicio : Controller
    {
     
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationDbContext _context;
        public MiServicio(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public string ObtenerEmailUsuario()
        {
            var numeroenstring = _httpContextAccessor.HttpContext.Session.GetString("MiSesion");
            if (numeroenstring != null)
            {
                var idSesion = int.Parse(numeroenstring);
                Usuario usuario = _context.Usuarios.Find(idSesion);
                var emailusuario = usuario.email;
                return emailusuario;

            }
            else
            {
                return null;
            }

        }
    }
}
