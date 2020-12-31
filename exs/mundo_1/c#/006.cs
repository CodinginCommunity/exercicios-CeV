  
// Crie um algoritmo que leia um número e mostre o seu dobro, o seu triplo e sua raiz quadrada

using System;

static class io {
    public static string input(string text) {
        Console.Write(text);
        return Console.ReadLine();
    }
    
    public static void print(object data, string end="\n") {
        string text = data.ToString();

        Console.Write($"{text}{end}");
    }
}

class Program {
    public static void Main() {
      double num;
      double dobro;
      double triplo;
      double raizQuadrada;

      num = double.Parse(io.input("Insira um número: "));
      dobro = (num*2);
      triplo = (num*3);
      raizQuadrada = Math.Sqrt(num);

      io.print($"O número digitado foi {num}");
      io.print($"{num} vezes 2 vale {dobro}");
      io.print($"Enquanto seu triplo vale {triplo}");
      io.print($"Já a raiz quadrada é {raizQuadrada}");
    }
}
