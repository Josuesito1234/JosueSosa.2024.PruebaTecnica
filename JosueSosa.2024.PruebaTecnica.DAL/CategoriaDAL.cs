using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JosueSosa._2024.PruebaTecnica.EN;
using Microsoft.EntityFrameworkCore;

namespace JosueSosa._2024.PruebaTecnica.DAL
{
    public class CategoriaDAL
    {
        public static async Task<Categoria> GetById(int id)
        {
            var categ = new Categoria();
            using (var dbContext = new ComunDB())
            {
                categ = await dbContext.Categorias.FirstOrDefaultAsync(p => p.Id == id);
            }
            return categ;
        }
        public static async Task<int> Create(Categoria Categoria)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                bdContext.Add(Categoria);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Update(Categoria Categoria)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {/*La "a" es el alias de la tabla*/
                var categ = await bdContext.Categorias.FirstOrDefaultAsync(a => a.Id == Categoria.Id);
                categ.Nombre = Categoria.Nombre;
                bdContext.Update(categ);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Delete(Categoria Categoria)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {/*La "a" es el alias de la tabla*/
                var categ = await bdContext.Categorias.FirstOrDefaultAsync(a => a.Id == Categoria.Id);
                bdContext.Remove(categ);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<List<Categoria>> GetAll()
        {
            var categ = new List<Categoria>();
            using (var dbContext = new ComunDB())
            {
                categ = await dbContext.Categorias.ToListAsync();
            }
            return categ;
        }
    }
}