using System;

namespace Practica06 {
  public class Persona {

    private string cedula;
    private string nombre;
    private string apellido;
    private int edad;

    public string Nombre{
      get{return nombre;}
      set{nombre=value;}
    }    

    public string Cedula{
      get{return cedula;}      
      set{cedula=value;}
    }
    public string Apellido{
      get{return apellido;}      
      set{apellido=value;}
    }

    public int Edad{
      get{return edad;}      
      set{edad=value;}
    }
    public void Responsabilidad(){
      Console.WriteLine("Cedula: " + Cedula + "\nNombre: " + Nombre + "\nApellido: " + Apellido + "\nEdad: " + Edad);
    }

  }

  public class Profesor : Persona{

    private double sueldo;

    public double Sueldo{
      get{return sueldo;}      
      set{
        if(value<0)
          sueldo=0;
        else
          sueldo=value;
      }
    }

    public void MostrarSueldo(){
      Console.WriteLine("Sueldo del profesor: " + Sueldo + "\n");
    }
  }
}
