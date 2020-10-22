using System;

class Profesor: Persona{

    private int experiencia;

    public Profesor(int unDni, string unNombre, string unApellido, string unaFechaNacimiento, int cantExperiencia){
        this.Dni = unDni;
        this.Nombre = unNombre;
        this.Apellido = unApellido;
        this.FechaNacimiento = unaFechaNacimiento;
        this.experiencia = cantExperiencia;
    }

    public int Experiencia {
        get { return this.experiencia; }
        set { this.experiencia = value; }
    }
}