using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcFeei.Models
{
    public class Alumno
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Matricula")]
        public string AlumnoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El campo {0} debe ser una cadena con un mínimo {1} y un máximo de {2} carácteres.")]
        public string Nombre { get; set; }

        [DisplayName("Ficha de ingreso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Date, ErrorMessage = "El campo {0} debe de ser una fecha")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(8, ErrorMessage = "El campo {0} debe ser una cadena con un máximo de {1} carácteres.")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(1, 10, ErrorMessage = "El campo {0} debe ser un mínimo de {1} y un máximo de {2}.")]
        [Column(TypeName = "decimal(18, 2)")]

        public decimal Promedio { get; set; }
    }
}
