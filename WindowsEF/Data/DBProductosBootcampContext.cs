using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // ----> Uso esto
using WindowsEF.Models;

namespace WindowsEF.Data
{
    public class DBProductosBootcampContext : DbContext
    {
        //Constructor
        public DBProductosBootcampContext() : base ("KeyDB") { }

        //Propiedades DBSet
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
       


    }
}
