using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoVersion95.Models
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }

        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }
        public Pedido pedido { get; set; }

        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public int IdTienda { get; set; }
        public string NombreProducto { get; set; }
        
    }
}
