using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoVersion95.Models
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        public virtual List<Item> Items { get; set; }

        public double PrecioTotal { get; set; }
    }
}
