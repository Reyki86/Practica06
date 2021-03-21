using System;

namespace Practica06 {
  public class Contacto {

    private string nombre;
    private string apellido;
    private string telefono;
    private string direccion;

    public string Nombre{
      get{return nombre;}      
      set{nombre=value;}
    }

    public string Apellido{
      get{return apellido;}      
      set{apellido=value;}
    }

    public string Telefono{
      get{return telefono;}      
      set{telefono=value;}
    }

    public string Direccion{
      get{return direccion;}      
      set{direccion=value;}
    }

    public void SetContacto(string nombre,string apellido, string telefono, string direccion){

      Nombre=nombre;
      Apellido=apellido;
      Telefono=telefono;
      Direccion=direccion;

    }

    public void Saludar(){
      Console.WriteLine("Hola, soy " + Nombre + " " + Apellido + ", mi telefono es " + telefono + " y mi direccion es " + Direccion + "\n");
    }

  } 

  public class ProbarContacto{

    public static void main(){

      Contacto contacto1 = new Contacto();
      Contacto contacto2 = new Contacto();

      contacto1.SetContacto("Manuel","Castillo","829-436-7541","Calle Naranjo #6, Urbanizacion Maximo Gomez, Villa Mella, Santo Domingo Norte");

      contacto2.SetContacto("Samantha","Rosario","849-214-6854","Calle Azucena #4 Primer nivel, Residencial Gamuni, La Vega");

      contacto1.Saludar();
      contacto2.Saludar();

    }

  }

}