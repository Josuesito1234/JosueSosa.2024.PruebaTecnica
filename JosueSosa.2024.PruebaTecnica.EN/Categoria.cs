using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosueSosa._2024.PruebaTecnica.EN
{
    public class Categoria
    {
         public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre solo puede contener letras.")]
        public string? Nombre { get; set; }
       
    }
}
