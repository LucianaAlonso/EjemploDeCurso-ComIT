using System;
using System.Collections.Generic;

namespace Ejercicio_dotnet_curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nuevo Curso");

            Profesor calosPerez = new Profesor(10101010, "Carlos", "Perez", "10/10/1964", 30);
            Alumno juanMarquez = new Alumno(20202020, "Juan", "Marquez", "05/08/1996", true);
            Alumno lauraGonzalez = new Alumno(30303030, "Laura", "Gonzalez", "23/07/2000", false);
            Alumno lucianaAlonso = new Alumno(40404040, "Luciana", "Alonso", "27/01/1993", true);
            string nombreCurso = "DotNetComIT";
            int cantMaxAlumnos = 20;
            List<Alumno> listaDeAlumnos = new List<Alumno>();
            listaDeAlumnos.Add(juanMarquez);
            listaDeAlumnos.Add(lauraGonzalez);
            listaDeAlumnos.Add(lucianaAlonso);

            Curso dotNet = new Curso(nombreCurso, cantMaxAlumnos, calosPerez, listaDeAlumnos);

            dotNet.MostrarInfo();
        }
    }
}
