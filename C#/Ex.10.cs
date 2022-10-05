using System;

class Program {
  public static void Main (string[] args) {
    int[,,] numero = new int [3, 2, 3];

    for(int l = 0; l < 3; l++){
      for(int c = 0; c < 2; c++){
        for(int lc = 0; lc < 3; lc++){
          Console.WriteLine("Insira um número: ");
          numero[l, c, lc] = Convert.ToInt32(Console.ReadLine());
        }
      }
    }
  }
}