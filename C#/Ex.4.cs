using System;

class Program {
  public static void Main (string[] args) {
    int[] v1 = new int[4];
    int[] v2 = new int[4];
    int[] v3 = new int[4];
    int v;

    for(v = 0; v < 4; v++){
      Console.WriteLine("Insira um números: ");
      v1[v] = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Insira um números: ");
      v2[v] = Convert.ToInt32(Console.ReadLine()); 

      v3[v] = v1[v] + v2[v];
    }
    for(v = 0; v < 4; v++){
    Console.WriteLine($"n1 + n2 = [{v3[v]}]");
    }
  }
}