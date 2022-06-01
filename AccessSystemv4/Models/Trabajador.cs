using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccessSystemv4.Models
{
    public class Trabajador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se debe ingresar el nombre del trabajador")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe ingresar el apellido del trabajadro")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Se debe ingresar la llave del trabajador")]
        [StringLength(4)]
        [Display(Name = "Llave")]
        public string Llave { get; set; }

        [Required(ErrorMessage = "Se debe ingresar el cargo del trabajador")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        
        [ForeignKey("FK_Gerencia")]
        [Required(ErrorMessage = "Se debe ingresar la gerencia del trabajador")]
        public Gerencia Gerencia { get; set; }

        [Required(ErrorMessage = "Se debe ingresar la fecha de registro")]
        [DataType(DataType.Date)]
        [Display(Name = "FechaEntrada")]
        public DateTime FechaEntrada { get; set; }

        [Required(ErrorMessage = "Se debe ingresar la fecha de salida")]
        [DataType(DataType.Date)]
        [Display(Name = "FechaSalida")]
        public DateTime FechaSalida { get; set; }

        [ForeignKey("FK_Supervisor")]
        [Required(ErrorMessage = "Se debe ingresar el supervisor del trabajador")]
        [Display(Name = "SupervisorId")]
        public Trabajador SupervisorId { get; set; }
    }
}
