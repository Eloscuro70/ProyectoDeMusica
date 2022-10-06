using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_De_Instrumentos_Musicales.EntidadesDeNegocio;

namespace Tienda_De_Instrumentos_Musicales.AccesoADatos
{
    public class BDContexto : DbContext
    {
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(@"Data Source-DESKTOP-NC7I8PM\SQLEXPRESS;Initial Catalog=Tienda_De_Instrumentos_Musicales;Integrated Security=True");
        }
    }
}
