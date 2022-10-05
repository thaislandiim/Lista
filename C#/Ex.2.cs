using System;

class Program {
  public static void Main (string[] args) {
    int[] numero = new int[4];
    
    Console.WriteLine("Insira um número: ");
    numero[0] = Convert.ToInt32(Console.ReadLine());
    
    for(int n = 0; n < 3; n++){
      numero[n + 1] = numero[n] + 1;
    }
    for(int n = 0; n < 4; n++){
      Console.Write($"[{numero[n]}]");
    }
  }
}