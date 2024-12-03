using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JosueSosa._2024.PruebaTecnica.EN;
using JosueSosa._2024.PruebaTecnica.DAL;

namespace JosueSosa._2024.PruebaTecnica.BL
{
    public class CategoriaBL
    {
        public static async Task<Categoria> GetById(int id)
        {
            return await CategoriaDAL.GetById(id);
        }
        public static async Task<List<Categoria>> GetAll()
        {
            return await CategoriaDAL.GetAll();
        }
        public static async Task<int> Create(Categoria Categoria)
        {
            return await CategoriaDAL.Create(Categoria);
        }
        public static async Task<int> Update(Categoria Categoria)
        {
            return await CategoriaDAL.Update(Categoria);
        }
        public static async Task<int> Delete(Categoria Categoria)
        {
            return await CategoriaDAL.Delete(Categoria);
        }
    }
}
