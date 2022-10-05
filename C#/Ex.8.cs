using System;

class Program {
  public static void Main (string[] args) {
    int[,] numeros = new int [3,2];

    for(int l = 0; l < 3; l++){
      for(int c = 0; c < 2; c++){
        Console.WriteLine("Insira um número:");
        numeros[l,c] = Convert.ToInt32(Console.ReadLine());
      }
    }

    for(int l = 0; l < 3; l++){
      for(int c = 0; c < 2; c++){
        if(numeros[l,c] % 3 == 0){
          Console.Write($"[{numeros[l,c]}]");
        }
      }
    }
  }
}