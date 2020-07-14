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


        public async Task<IActionResult> MisPedidos()
        {
            var IdUsuarioEnString = HttpContext.Session.GetString("MiSesion");
            int IdUsuarioEnInt = int.Parse(IdUsuarioEnString);
            var ListaItemsDelPedido = _context.Items;
            var TodosLosPedidos = _context.Pedidos.Where(p => p.IdUsuario == IdUsuarioEnInt);

            var ListaItemsDePedidos = new List<Item>();
            foreach (var p in TodosLosPedidos) {
                var Items = _context.Items.Where(i => i.IdPedido == p.IdPedido);
                foreach (var i in Items) {
                    ListaItemsDePedidos.Add(i);
                }
            }
            ViewBag.ListaItemsDePedidos = ListaItemsDePedidos;
            //Hacemos las dos busquedas, pedido e items (funciona como un inner join)

            //Pedido pedidoFinalDeBD = await _context.Pedidos.FindAsync(IdPedidoGenerado);
            //var ListaItemsDelPedido = _context.Items.Where(i => i.IdPedido == IdPedidoGenerado);


            //List<Pedido> PedidosCompletos = new List<Pedido>();

            //foreach (var IdUsuarioEnInt in PedidosCompletos)
            //{

            //}

            return View(TodosLosPedidos.ToList<Pedido>());
        }




    }
}
