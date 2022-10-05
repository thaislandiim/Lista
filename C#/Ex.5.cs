using System;

class Program {
  public static void Main (string[] args) {
   int[,] numeros = new int[2,2];
    int l, c;

    for(l = 0; l < 2; l++){
      for(c = 0; c < 2; c++){
        Console.WriteLine("Insira um número: ");
        numeros[l,c] = Convert.ToInt32(Console.ReadLine());
      }
    }
  }
}