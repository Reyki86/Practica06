using System;

namespace Practica06 {
  public class ClaseA {
    public ClaseA(){
      Console.WriteLine("Esta es la clase A");
    }
  }

  public class ClaseB : ClaseA {
    public ClaseB(){
      Console.WriteLine("Esta es la clase B");
    }
  }
  
  public class ClaseC : ClaseB {
    public ClaseC(){
      Console.WriteLine("Esta es la clase C");
    }
  }

}