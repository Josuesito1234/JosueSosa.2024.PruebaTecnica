using JosueSosa._2024.PruebaTecnica.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JosueSosa._2024.PruebaTecnica.DAL
{
    public class ProductoDAL
    {
        public static async Task<Producto> GetById(int id)
        {
            var prod = new Producto();
            using (var dbContext = new ComunDB())
            {
                prod = await dbContext.Productos.FirstOrDefaultAsync(p => p.Id == id);
            }
            return prod;
        }
        public static async Task<int> Create(Producto Producto)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                bdContext.Add(Producto);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Update(Producto Producto)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var prod = await bdContext.Productos.FirstOrDefaultAsync(a => a.Id == Producto.Id);
                prod.Nombre = Producto.Nombre;
                prod.Precio = Producto.Precio;
                prod.CategoriaId = Producto.CategoriaId;
                bdContext.Update(prod);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Delete(Producto Producto)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var prod = await bdContext.Productos.FirstOrDefaultAsync(a => a.Id == Producto.Id);
                bdContext.Remove(prod);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<List<Producto>> GetAll()
        {
            var prod = new List<Producto>();
           using ( var bdcontext = new ComunDB())
            {
                prod = await bdcontext.Productos.ToListAsync();
            }
            return prod;
        }
    }
}
