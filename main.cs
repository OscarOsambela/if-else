using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Ingresa tu primera nota");
    float primeraNota = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa tu segunda nota");
    float segundaNota = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa tu tercera nota");
    float terceraNota = int.Parse(Console.ReadLine());
    float promedio = (primeraNota + segundaNota + terceraNota)/3;
    if(promedio > 10){
      Console.WriteLine("Tu promedio es " + promedio);
      Console.WriteLine("Estás aprobado");
    }else{
      Console.WriteLine("Tu promedio es " + promedio);
      Console.WriteLine("Estás desaprobado");
    }
  }
}