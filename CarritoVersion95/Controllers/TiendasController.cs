using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CarritoVersion95.Data;
using CarritoVersion95.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CarritoVersion95.Controllers
{
    public class TiendasController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TiendasController(ApplicationDbContext servicioInyectado)
        {
            _context = servicioInyectado;
        }

        public async Task<IActionResult> ListaProductosAPI()
        {

            string url = "http://le-charlotte.com/home/productosAPI";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.GetStringAsync(url);
                var listaProductos = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
                return View(listaProductos);
            }


        }
        [HttpPost]
        public async Task<IActionResult> AgregarACarritoAsync(Item item)
        {
            double precioUnitario = 0;
            
            string url = "http://le-charlotte.com/home/productosAPI";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.GetStringAsync(url);
                var listaProductos = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
                var i = 0;
                Boolean encontrado = false;
                Producto producto = null;
                
                while (!encontrado && i < listaProductos.Count())
                {
                    if (listaProductos[i].IdProducto == item.IdProducto)
                    {
                        producto = listaProductos[i];
                        encontrado = true;
                    } else
                    {
                        i++;
                    }
                  
                }
                
                if (producto != null)
                {
                    item.IdTienda = producto.IdTienda;
                    item.NombreProducto = producto.NombreProducto;
                    precioUnitario = producto.PrecioProducto;
                    }

               }
           
           
            var listaDeStrings = HttpContext.Session.GetString("MiCarrito");
            if (listaDeStrings != null)
            {

                var listaItems = JsonConvert.DeserializeObject<List<Item>>(listaDeStrings);
                var i = 0;
                while (i < listaItems.Count && listaItems[i].IdProducto != item.IdProducto)
                {
                    i++;
                }
                if (i < listaItems.Count) // encontré el item en el carrito, modificar cantidad
                {
                    listaItems[i].Cantidad += item.Cantidad;
                    listaItems[i].Precio = precioUnitario * listaItems[i].Cantidad;
                    
                }
                else // agregar al carrito
                {
                    item.Precio = precioUnitario * item.Cantidad;
                    listaItems.Add(item);
                }


                var ListaEnString = JsonConvert.SerializeObject(listaItems);
                HttpContext.Session.SetString("MiCarrito", ListaEnString);

            }
            else
            {
                var listaItems = new List<Item>();
                item.Precio = precioUnitario * item.Cantidad;
                listaItems.Add(item);
                var ListaEnString = JsonConvert.SerializeObject(listaItems);
                HttpContext.Session.SetString("MiCarrito", ListaEnString);
            }

            

            return RedirectToAction("Carrito", "Tiendas");
            //return NoContent();

        }

        [HttpGet]
        public IActionResult Carrito()
        {
            var listaDeStrings = HttpContext.Session.GetString("MiCarrito");

            // Verifico que haya una sesion activa, si no hay envio un mensaje para desabilitar el boton finalizar compra
            var numeroenstring = HttpContext.Session.GetString("MiSesion");
            if (numeroenstring == null)
            {
                ViewBag.MsjErrorLoginNecesario = "Necesitás loguearte";
            }

            if (listaDeStrings != null) { 
            var listaDeProductos = JsonConvert.DeserializeObject<List<Item>>(listaDeStrings);
            double precioTotal = 0;

            foreach (var Item in listaDeProductos)
            {
                precioTotal += Item.Precio;
            }

            ViewBag.PrecioTotal = (decimal)precioTotal;

            return View(listaDeProductos);
            }
            return View(new List<Item>());
        }

        
        public IActionResult EliminarItem(int? IdProd)
        {
            var listaDeStrings = HttpContext.Session.GetString("MiCarrito");
            var listaItems = JsonConvert.DeserializeObject<List<Item>>(listaDeStrings);
            int i = 0;
            while (i < listaItems.Count && listaItems[i].IdProducto != IdProd)
            {
                i++;
            }
            if (i < listaItems.Count) // encontré el item en el carrito, lo saco
            {
                listaItems.RemoveAt(i);
            }
            var ListaEnString = JsonConvert.SerializeObject(listaItems);
            HttpContext.Session.SetString("MiCarrito", ListaEnString);

            return RedirectToAction("Carrito", "Tiendas");
        }

        public async Task<IActionResult> FinalizarCompra()
        {
            // Verifico que haya una sesion activa
            var numeroenstring = HttpContext.Session.GetString("MiSesion");
            if (numeroenstring == null)
            {
                ViewBag.MsjErrorLoginNecesario = "Necesitás loguearte";
                return RedirectToAction("Carrito", "Tiendas");
            }

            //var usuario = await _context.Usuarios.FindAsync(IdUsuarioBuscado);


            double precioTotal = 0;

            var listaDeStrings = HttpContext.Session.GetString("MiCarrito");
            

            // Primero verifico que haya productos en el carrito
            if (listaDeStrings == null)
            {
                ViewBag.MsjErrorNoTenesProdEnCarrito = "No tenés productos en el carrito";
                return RedirectToAction("Carrito", "Tiendas");
            }

            

            var IdUsuarioBuscado = int.Parse(numeroenstring);
            var listaItems = JsonConvert.DeserializeObject<List<Item>>(listaDeStrings);

            // Recorro la lista de items para obtener el precio total del pedido
            foreach (var Item in listaItems)
            {
                precioTotal += Item.Precio;
            }

            // Creo un nuevo pedido para agregar los valores
            Pedido pedido = new Pedido();
            pedido.IdUsuario = IdUsuarioBuscado;
            pedido.PrecioTotal = precioTotal;
            

            //Guardamos el pedido en la BD
            _context.Add(pedido);
            await _context.SaveChangesAsync();

            //Agarramos el ID del pedido que mandamos a la BD que se genero automaticamente. 
            //Una vez guardado el objeto en la BD, EF completa el dato del ID generado en la base de datos automaticamente en el objeto que teniamos.
            var IdPedidoGenerado = pedido.IdPedido;

            
            //Recorro la lista para agregar el numero de pedido a cada item
            foreach (var Item in listaItems)
            {
                Item.IdPedido = IdPedidoGenerado;
            }

            //Agrego la lista de items al pedido.
            pedido.Items = listaItems;

            //Actualizo los datos del pedido en la BD
            _context.Update(pedido);
            await _context.SaveChangesAsync();

            //Hacemos las dos busquedas, pedido e items (funciona como un inner join)
            Pedido pedidoFinalDeBD = await _context.Pedidos.FindAsync(IdPedidoGenerado);
            var ListaItemsDelPedido = _context.Items.Where(i => i.IdPedido == IdPedidoGenerado);

            //Limpio el carrito para sacar los productos de la sesion
            var ListaVacia = new List<Item>();
            var ListaVaciaString = JsonConvert.SerializeObject(ListaVacia);
            HttpContext.Session.SetString("MiCarrito", ListaVaciaString);

            return View(pedidoFinalDeBD);
        }

    }

}


//public async Task<IActionResult> AgregarACarritoAsync(Item item)
//{
//    var cantidad = item.Cantidad;
//    var id = item.IdProducto;

//    var producto = await alberto.Productos.FindAsync(id);
//    var precioDelProducto = producto.PrecioProducto;

//item.Precio = cantidad* precioDelProducto;

//var listaDeStrings = HttpContext.Session.GetString(SessionName);
//    if (listaDeStrings != null)
//    {
//        var listaItems = JsonConvert.DeserializeObject<List<Item>>(listaDeStrings);
//var i = 0;
//        while (i<listaItems.Count && listaItems[i].IdItem != item.IdItem)
//        {
//            i++;
//        }
//        if (i<listaItems.Count) // encontré el item en el carrito, modificar cantidad
//        {
//            listaItems[i].Cantidad += item.Cantidad;
//        }
//        else // agregar al carrito
//        {
//            listaItems.Add(item);
//        }


//        GuardarLaListaEnLaSesion(listaItems);
//    }
//    else
//    {
//        var listaItems = new List<Item>();
//listaItems.Add(item);
//        GuardarLaListaEnLaSesion(listaItems);
//    }

//    return NoContent();

//}