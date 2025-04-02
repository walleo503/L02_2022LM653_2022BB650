using Microsoft.EntityFrameworkCore;

namespace L02_2022LM653_2022BB650.Models
{
    public class dastosDbConext : DbContext
    {
        public dastosDbConext(DbContextOptions options) : base(options) {
        
        }

        public DbSet<clientes> clientes { get; set; }
        public DbSet<pedidoEncabezado> pedido_encabezado { get; set; }
        public DbSet<pedido_detalle> pedido_detalle { get; set; }

        public DbSet<libros> libros { get; set; }

    }
}
