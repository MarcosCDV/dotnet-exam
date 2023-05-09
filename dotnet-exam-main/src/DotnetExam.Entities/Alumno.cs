namespace DotnetExam.Entities
{
    public class Alumno:Persona
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }

        public Alumno(int alumnoID, string nombre, string apellido, String legajo)
        {
            this.Id = alumnoID;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.AlumnoId = alumnoID;
            this.Legajo = legajo;
        }

        public Alumno()
        {
        }

        public override string NombreCompleto()
        { 
            return $"{Nombre} {Apellido}";    
        }

        public override string ToString()
        {
            return NombreCompleto();
        }

    }
}