using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarritoVersion95.Data;
using CarritoVersion95.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarritoVersion95.Controllers
{
    public class CuentaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CuentaController(ApplicationDbContext servicioInyectado)
        {
            _context = servicioInyectado;
        }

        [HttpGet]
        public async Task<IActionResult> MiCuentaAsync()
        {
            var numeroenstring = HttpContext.Session.GetString("MiSesion");

            //Verificar si esta logueado, sino, mano a login
            if (numeroenstring == null)
            {
                return RedirectToAction("Login", "Login");
            }

            var IdUsuarioBuscado = int.Parse(numeroenstring);
            var usuario = await _context.Usuarios.FindAsync(IdUsuarioBuscado);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult MiCuenta(Usuario usuario)
        {
            _context.Update(usuario);
            _context.SaveChanges();
            return RedirectToAction("MiPanel", "Panel");
        }

        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult MisPedidos()
        {
            var IdUsuarioEnString = HttpContext.Session.GetString("MiSesion");
            int IdUsuarioEnInt = int.Parse(IdUsuarioEnString);

            var TodosLosPedidos = _context.Pedidos.Where(p => p.IdUsuario == IdUsuarioEnInt);


            return View(TodosLosPedidos.ToList<Pedido>());
        }


        //Este metodo debe eliminar un pedido
        //public async Task<IActionResult> CancelarPedidoAsync(int id)
        //{
        //    var PedidoACancelar = await _context.Pedidos.FindAsync(id);
        //    var Items = _context.Items.Where(i => i.IdPedido == id);
        //    _context.Pedidos.Remove(PedidoACancelar);
            
        //    _context.SaveChanges();


        //    return RedirectToAction("MisPedidos", "Cuenta");
        //}

    }
}
