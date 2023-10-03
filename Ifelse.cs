using System;

class UmIfelse {
  public static void Main (string[] args) {

// O algoritmo é simples: o programa pergunta a idade do usuário, que a digita, e, em seguida lhe fornece uma resposta automática dentre quatro possíveis.

  int age;
  string reponse1, reponse2, reponse3, reponse4, resultat;

// Declaração de variáveis.

  reponse1 = "Você é jovem";
  reponse2 = "Você é velho";
  reponse3 = "Você é menor de idade";
  reponse4 = "Você é um bebê";

// Atribuição de um valor (conteúdo) às variáveis.

  Console.WriteLine ("PROGRAMA PARA SABER SE VOCÊ É VELHO");
  Console.WriteLine ("Digite sua idade");
  age = int. Parse(Console. ReadLine());

  // O C# recebe digitações do teclado como string, por isso, é preciso converter essa string para int, nesse caso. 

  if (age < 19) {
    resultat = reponse3;
      }if (age < 4) {
        resultat = reponse4;

  }else if (age == 26){
    resultat = reponse1;
// == corresponde à igualdade

  }else{
    resultat = reponse2;
  }
  /* A diferença entre else if e else é: 
    if = se o caso for esse
    else if = se o caso for esse outro
    else = se o caso for qualquer outra coisa 
  */
    
  Console.WriteLine (resultat);

  Console.WriteLine ("Fim do programa");
    
}
  }
