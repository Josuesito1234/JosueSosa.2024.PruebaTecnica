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
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre solo puede contener letras.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio no puede ser negativo.")]
        public decimal? Precio { get; set;}

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public int CategoriaId { get; set; }

    }
}
