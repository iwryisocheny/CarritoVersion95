using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoVersion95.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string contrasenia { get; set; }
    }

}
