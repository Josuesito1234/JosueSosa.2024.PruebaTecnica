using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosueSosa._2024.PruebaTecnica.EN
{
    public class Producto
    {
        
        public int Id { get; set; }

        
        public string? Nombre { get; set; }

        
        public decimal? Precio { get; set;}

       
        public int CategoriaId { get; set; }

    }
}
