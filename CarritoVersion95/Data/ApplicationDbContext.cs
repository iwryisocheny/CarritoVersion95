using System;
using System.Collections.Generic;
using System.Text;
using CarritoVersion95.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarritoVersion95.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Item> Items { get; set; }
    }
}
