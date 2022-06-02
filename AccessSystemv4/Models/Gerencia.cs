using System.ComponentModel.DataAnnotations;

namespace AccessSystemv4.Models
{
    public class Gerencia
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se debe ingresar el Nombre de la gerencia")]
        [StringLength(9, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se debe ingresar la sigla de la gerencia")]
        [StringLength(9, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "SiglaGerencia")]
        public string SiglaGerencia { get; set; }
    }
}
