using System;

class Alumno: Persona{

    private bool trabaja;

    public Alumno(int unDni, string unNombre, string unApellido, string unaFechaNacimiento, bool trabaja){
        this.Dni = unDni;
        this.Nombre = unNombre;
        this.Apellido = unApellido;
        this.FechaNacimiento = unaFechaNacimiento;
        this.trabaja = trabaja;
    }

    public bool Trabaja {
        get { return this.trabaja; }
        set { this.trabaja = value; }
    }
}