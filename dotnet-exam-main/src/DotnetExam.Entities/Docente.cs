using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetExam.Entities
{
    public class Docente:Persona
    {
        public int DocenteId { get; set; }
        public int Antiguedad { get; set; }

        public Docente(int id, string nombre, string apellido)

        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            DocenteId = id;

        }

        public Docente(int id, string nombre, string apellido, int antiguedad)
       
        {
            Id = id;    
            Nombre = nombre;
            Apellido = apellido;
            DocenteId = id;
            Antiguedad = antiguedad;
        }

        public override string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
