using System;

namespace Practica06 {
    public class MainClass {
        static void Main() {

          Ejercicio1();

          Ejercicio2();
          
          Ejercicio3();
        }

        static void Ejercicio1(){
          
          Persona persona1 = new Persona();
          Profesor profesor1 = new Profesor();

          persona1.Cedula = "001-1348264-6";
          persona1.Nombre = "Juan";
          persona1.Apellido = "Alberto";
          persona1.Edad = 27;
          profesor1.Sueldo = 30800;

          persona1.Responsabilidad();
          profesor1.MostrarSueldo();

        }

        static void Ejercicio2(){

          ProbarContacto.main();

        }

        static void Ejercicio3(){

          ClaseC nuevaClase = new ClaseC();

        }

    }
}