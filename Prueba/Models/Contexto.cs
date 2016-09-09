using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Contexto:DbContext
    {
        public DbSet<PersonaModel> persona { get; set; }
        public DbSet<Alumno> alumno { get; set; }
    }
}