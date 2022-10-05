using System;

class Program {
  public static void Main (string[] args) {
    int[] numero = new int[10];
    int n;

    for(n = 0; n < 10; n++){
      Console.WriteLine("Insira um número: ");
      numero[n] = Convert.ToInt32(Console.ReadLine());
    }
    for(n = 0; n < 10; n++){
      if(numero[n] % 4 == 0){
      Console.WriteLine($"[{numero[n]}]");
      }
    }
  }
}