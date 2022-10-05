using System;

class Program {
  public static void Main (string[] args) {
    int[,] n = new int[2,4];
    int c, l;

    Console.WriteLine("Insira um número: ");
    n[0,0] = Convert.ToInt32(Console.ReadLine());

    for(l = 0; l < 2; l++){
      for(c = 0; c < 4; c++){
        if(l == 0 && c == 0){
        } else {
            if(c == 0){
            n[l,c] = n[l -1, 2] + 1;
          } else {
              n[l,c] = n[l, c - 1] + 1;
          }
        }
        Console.Write($"[{n[l,c]}]");
      }
      Console.WriteLine();
    }
  }
}