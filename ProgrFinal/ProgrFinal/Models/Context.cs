using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProgrFinal.Models
{
    public class Context:DbContext
    {

        public DbSet<ClientesModel> clientes { get; set; }
        public DbSet<ProveedoresModel> Proveedores { get; set; }
        public DbSet<PrductosModel> Productos { get; set; }
    }
}