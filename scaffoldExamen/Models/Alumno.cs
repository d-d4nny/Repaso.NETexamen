using System;
using System.Collections.Generic;
using System.Net;

namespace scaffoldExamen.Models
{
    public partial class Alumno
    {
        public long IdAlumno { get; set; }
        public string? Nombre { get; set; }

        public Alumno() { }

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return String.Format("\n\t--- Datos Alumno ---\nNombre: {0}", Nombre);
        }
    }
}
