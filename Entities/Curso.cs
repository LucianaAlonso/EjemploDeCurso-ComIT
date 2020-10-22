using System;
using System.Collections.Generic;

class Curso{

    private string nombre;
    private int cantMaxAlumnos;

    private Profesor profesor;
    private List<Alumno> listaDeAlumnos;

    public Curso(string unNombre, int unaCantMaxima, Profesor unProfesor, List<Alumno> alumnos){
        this.nombre = unNombre;
        this.cantMaxAlumnos = unaCantMaxima;
        this.profesor = unProfesor;
        this.listaDeAlumnos = alumnos;
    }

    public String Nombre{
        get { return this.nombre; }
        set { this.nombre = value;}  
    }

      public int CantMaxAlumnos{
        get { return this.cantMaxAlumnos; }
        set { this.cantMaxAlumnos = value;}  
    }

      public Profesor Profesor{
        get { return this.profesor; }
        set { this.profesor = value;}  
    }

      public List<Alumno> ListaDeAlumnos{
        get { return this.listaDeAlumnos; }
        set { this.listaDeAlumnos = value;}  
    }

    public void MostrarInfo() {
        Console.WriteLine("Nombre del Curso: " + this.nombre);
        Console.WriteLine("Cantidad Maxima de Alumnos Permitida: " + this.cantMaxAlumnos);
        Console.WriteLine("Profesor que Dicta el Curso: " + this.Profesor.Nombre);
        Console.WriteLine("Alumnos Inscriptos: ");
        GenerarAlumnosInscriptos();
    }

    private void GenerarAlumnosInscriptos() {
        foreach(Alumno a in listaDeAlumnos){
            Console.WriteLine("-" + a.Nombre + " " + a.Apellido);
        }
    }
}