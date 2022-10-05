using System;

class Program {
  public static void Main (string[] args) {
    int[,] numeros = new int[3,3];
    int l, coluna;

    Console.WriteLine("Insira um número: ");
    numeros[0,0] = Convert.ToInt32(Console.ReadLine());

    for(l = 0; l < 3; l++){
      for(coluna = 0; coluna < 3; coluna++){
        if(l == 0 && coluna == 0){
        } else {
          if(coluna == 0){
            numeros[l, coluna] = numeros[l - 1, 2] + 1;
          } else {
            numeros[l, coluna] = numeros[l, coluna - 1] + 1;
          }
        }
        Console.Write($"[{numeros[l,coluna]}]");
      } 
      Console.WriteLine();
    }
  }
}