using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace AccessSystemv4.Models
{
    public class AdminPersonal
    {
        public List<Trabajador> Tra { get; set; } 

        public List <Gerencia> Ge { get; set; }


    }
}
