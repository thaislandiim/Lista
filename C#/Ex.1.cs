using System;

class Program {
  public static void Main (string[] args) {
    int[] numero = new int[5];

    for(int n = 0; n < 5; n++){
      Console.WriteLine("Insira um número: ");
      numero[n] = Convert.ToInt32(Console.ReadLine());
    }
  }
}