using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class PersonaModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es requerido")]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
    }
}