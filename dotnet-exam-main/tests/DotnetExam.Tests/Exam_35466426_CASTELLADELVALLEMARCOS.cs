using DotnetExam.Entities;
using Xunit;

namespace DotnetExam.Tests
{
    public class Exam_DNIXXX_APELLIDOYYY
    {
        [Fact]
        public void Test1_Teoria_NET()
        {

            //Describa la diferencia entre .NET Framework y .NET Core
            var respuesta = 
                "La principal diferencia en .NET Framework y .NET Core es que .NET Framework es " +
                "todo el ecosistema de microsoft donde esta incluido .NET Core,C#,F#,Visual Basic,etc." +
                " En el .NET Framework no solo están" +
                "incluidos los lengujes desarrollados por miscrosoft sino tambien muchos otros creados " +
                "por la comunidad. .NET Core es parte de .NET Framework y se lo diseñó para que sea multiplataforma " +
                ",es decir, que los projectos/soluciones/sitemas creados" +
                "con .NET Core se lo puede ejecutar en Windows,Linux,Mc Os";

            Assert.NotEqual(string.Empty, respuesta);


        }

        [Fact]
        public void Test2_Teoria_Assembly()
        {


            //Describa que es un assembly o ensamblado en .NET
            var respuesta = "Un ensamblado son los .dll(librerias,metadatos) y los .exe(codigo ejecutable). Estos contienen el código ejecutable, metadatos sobre los tipos, referencias a otros ensamblado si corresponde" +
                "y configuraciones necesarias. El ensamblado de algun lenguaje de .NET Framework" +
                ",es decir, cualquier lenguaje que sea compatible con la CLR (Common Languague Runtime) se pueden usar entre sí, como por ejemplo, usar alguna libreria echa en Visaul Basic en una" +
                "aplicacion en C#";

            Assert.NotEqual(string.Empty, respuesta);


        }


        [Fact]
        public void Test3_Teoria_IL()
        {


            //Describa que es el Lenguaje Intermedio o IL
            var respuesta = "Cuando se compila un programa en .NET, el compilador genera un archivo ejecutable o un " +
                "archivo de biblioteca de clases que contiene el código fuente compilado en CIL. " +
                "El CIL se compila en código de máquina específico de la plataforma en tiempo de ejecución" +
                " por el Just-In-Time (JIT) compiler, que convierte el código de máquina CIL en código de máquina nativo" +
                " que puede ser ejecutado directamente en el procesador ya que el compilador transforma el código en uno" +
                "de bajo nivel.";

            Assert.NotEqual(string.Empty, respuesta);


        }




        [Fact]
        public void Test4_DateTime_Formatting()
        {
           

            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);


            Assert.Equal("18/12/22 15:30:23", finalWorldCupMatch.ToString("dd/MM/yy HH:mm:ss"));
            Assert.Equal("18/12/22 03:30 p. m.", finalWorldCupMatch.ToString("dd/MM/yy hh:mm tt"));
            Assert.Equal("18 de diciembre de 2022", finalWorldCupMatch.ToString("dd 'de' MMMM 'de' yyyy"));


        }

        [Fact]
        public void Test5_DateTime_Days()
        {


            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);
            var today = new DateTime(2023, 5, 9, 15, 00, 00);

            var diaTranscurridos = Math.Floor((today - finalWorldCupMatch).TotalDays);
            var result = $"{diaTranscurridos} Días totales desde la final del mundo";

            Assert.Equal("141 Días totales desde la final del mundo", result );

        }


        
        [Fact]
        public void Test6_POO_Alumno()
        {
            var alumno = new Alumno(123456,"Lionel","Messi", "000010/22");

            Assert.Equal(123456, alumno.AlumnoId);
            Assert.Equal("000010/22", alumno.Legajo);
            Assert.Equal("Lionel Messi", alumno.NombreCompleto());
        }


        
        [Fact]
        public void Test6_POO_Materia()
        {
            var materia = new Materia(123456, "Programacion III");

            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

        }
        
        [Fact]
        public void Test8_POO_UML()
        {
            //En base al diagrama UML del examen
            //Codifique las clases e interfaces necesarias

            var docente = new Docente(1, "Lionel", "Scaloni");

            var alumno1 = new Alumno()
            {
                Id = 101010,
                AlumnoId = 101010,
                Legajo = "101010/22",
                Nombre = "Lionel",
                Apellido = "Messi"
            }; 


            var alumno2 = new Alumno()
            {
                Id = 777,
                AlumnoId = 777,
                Legajo = "000007/22",
                Nombre = "Rodrigo",
                Apellido = "De Paul"
            };


            var materia = new Materia(123456, "Programacion III", docente)
            {
                Profesor = docente
            };
            materia.Alumnos.Add(alumno1);
            materia.Alumnos.Add(alumno2);



            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

            Assert.Equal(1, materia.Profesor.Id);
            Assert.Equal(1, materia.Profesor.DocenteId);
            Assert.Equal("Lionel", materia.Profesor.Nombre);
            Assert.Equal("Scaloni", materia.Profesor.Apellido);

            Assert.Equal(101010, materia.Alumnos.First().Id);
            //Assert.Equal(101010, materia.Alumnos.First().Legajo);
            Assert.Equal(101010, materia.Alumnos.First().AlumnoId);
            Assert.Equal("Lionel", materia.Alumnos.First().Nombre);
            Assert.Equal("Messi", materia.Alumnos.First().Apellido);

            Assert.Equal(777, materia.Alumnos.Last().Id);
            Assert.Equal(777, materia.Alumnos.Last().AlumnoId);
            Assert.Equal("000007/22", materia.Alumnos.Last().Legajo);
            Assert.Equal("Rodrigo", materia.Alumnos.Last().Nombre);
            Assert.Equal("De Paul", materia.Alumnos.Last().Apellido);

        }

        
          [Fact]
        public void Test9_Collection_GetCountFirtLast()
        {
            //Utilice la coleccion del trabajo practico que presento
            //Para poder con el generador completar dicha coleccion
            //y buscar las primeras materias y primeros y ultimos alumnos
            var materias = new Stack<Materia>(MateriaGenerador.Generar(10000, 1000));

            Assert.Equal(10000, materias.Count);

            Assert.Equal(1000, materias.First().Alumnos.Count);
            Assert.Equal("M10000-000001/23", materias.First().Alumnos.First().Legajo);
            Assert.Equal("M10000-001000/23", materias.First().Alumnos.Last().Legajo);

            for (int i = 0; i < 9999; i++)
            {
                materias.Pop();
            }

            Assert.Equal(1000, materias.Peek().Alumnos.Count);
            Assert.Equal("M1-000001/23", materias.Last().Alumnos.First().Legajo);
            Assert.Equal("M1-001000/23", materias.Last().Alumnos.Last().Legajo);

        }

        /*
        [Fact]
        public void Test10_Linq_BuscarLegajo()
        {
            //Busque los alumnos en las materias que contengan el legajo 000999
            //Utilice la coleccion del trabajo practico que presento
            var materias = new List<Materia>();

            materias.AddRange(MateriaGenerador.Generar(10000, 1000));

            //Ayuda: where a.Legajo.Contains("000999/23")
            var query = null;

            Assert.Equal(1000, query.ToList().Count);

        }*/
    }
}
