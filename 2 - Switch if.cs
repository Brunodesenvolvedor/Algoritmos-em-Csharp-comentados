using System;

class Program {
  public static void Main (string[] args) {

    char escolha;
    int num, num2;

    inicio:
    
    Console.WriteLine ("CALCULADORA DE SOMA E SUBTRAÇÃO");
    Console.WriteLine ("Você deseja somar (A) ou subtrair(B)?");
    escolha=char.Parse(Console.ReadLine());

    switch(escolha){
    case 'a':
    case 'A':
      Console.WriteLine ("Digite o primeiro número:");
      num = int.Parse(Console.ReadLine());
      Console.WriteLine ("Digite o segundo número:");
      num2 = int.Parse(Console.ReadLine());
      Console.WriteLine ("A soma de ambos é: {0}", num + num2);
      goto inicio;
      break;
      
    case 'b':
    case 'B':
      maior:
      Console.WriteLine ("Digite o maior número");
      num = int.Parse(Console.ReadLine());
      Console.WriteLine ("Digite o menor número");
      num2 = int.Parse(Console.ReadLine());
      if (num < num2){
          Console.WriteLine ("O primeiro número deve ser maior do que o segundo. Esta calculadora é fraquinha.");
          goto maior; 
       }
      Console.WriteLine ("O resultado da subtração é {0}", num - num2);
      goto inicio;
      
    default:
      Console.WriteLine ("Escreva direito");
      goto inicio;
    }
    
  }
}