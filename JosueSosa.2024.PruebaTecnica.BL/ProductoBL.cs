using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JosueSosa._2024.PruebaTecnica.EN;
using JosueSosa._2024.PruebaTecnica.DAL;

namespace JosueSosa._2024.PruebaTecnica.BL
{
    public class ProductoBL
    {
        public static async Task<Producto> GetById(int id)
        {
            return await ProductoDAL.GetById(id);
        }
        public static async Task<List<Producto>> GetAll()
        {
            return await ProductoDAL.GetAll();
        }
        public static async Task<int> Create(Producto Producto)
        {
            return await ProductoDAL.Create(Producto);
        }
        public static async Task<int> Update(Producto Producto)
        {
            return await ProductoDAL.Update(Producto);
        }
        public static async Task<int> Delete(Producto Producto)
        {
            return await ProductoDAL.Delete(Producto);
        }
    }
}
