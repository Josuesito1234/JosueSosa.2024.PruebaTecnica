using JosueSosa._2024.PruebaTecnica.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace JosueSosa._2024.PruebaTecnica.DAL
{
    public class ComunDB : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source = DESKTOP-NFDMETJ\\SQLEXPRESS; Initial Catalog = PruebatecnicaDB; Integrated Security = True; Trust Server Certificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(p => p.Id);  // Asegura que Id es la clave primaria
                entity.Property(p => p.Id).ValueGeneratedOnAdd();  // Indica que el Id es generado automáticamente (IDENTITY)
            });
        }
    }
}
