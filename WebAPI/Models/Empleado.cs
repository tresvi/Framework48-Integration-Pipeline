using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Empleado(int id, string nombre, string apellido) 
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}