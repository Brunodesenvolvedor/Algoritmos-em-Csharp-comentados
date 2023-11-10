using System;

class Program {
  public static void Main (string[] args) {

int resultat1, resultat2, aa, bb, cc, dd, t; 
Random d6 = new Random();
char essay1, essay2;
string mensagem;

inicio:
    
// Número aleatório entre um e dois.
// No caso desse jogo, toda jogada é aleatória, mas seria ideal o número correto ser predefinido aleatoriamente.

Console.WriteLine ("PIOR JOGO DA MEMÓRIA DO MUNDO");
Console.WriteLine ("Atrás das quatro letras há dois pares de números");
Console.WriteLine ("Descubra um par em duas tentativas");
Console.WriteLine ("Digite a primeira letra que deseja investigar: A, B, C, D");

int a = d6.Next(1,3);
aa = a;
int b = d6.Next(1,3);
bb = b;
int c = d6.Next(1,2);
cc = c;
int d = d6.Next(1,2);  
dd = d;
t = 0;
    
if (a == b){
  t++;
  }else if (a==c){
  t++;
  }else if (a==d){
  t++;
  }else if (b==a){
  t++;
  }else if (b==c){
  t++;
  }else if (b==d){
  t++;
  }else if (c==d){
  t++;
  }
    
while (t > 1){
int a2 = d6.Next(1,2);
aa = a2;
int b2 = d6.Next(1,2);
bb = b2;
int c2 = d6.Next(1,2);
cc = c2;
int d2 = d6.Next(1,2);  
dd = d2;
// Tentei usar as mesmas variáveis do numero aleatório lá de trás, contudo, deu erro, como seu estivesse usando a mesma variavel em dois lugares. Então fiz outras variáveis locais.
}
    
essay1=char.Parse(Console.ReadLine());

switch(essay1){
case 'a':
case 'A':
mensagem = ("Agora digite a segunda letra que deseja investigar: B, C, D");
  Console.WriteLine ("O número oculto em A é {0}", aa);
  resultat1= aa;
  break;
case 'b':
case 'B':
mensagem = ("Agora digite a segunda letra que deseja investigar: A, C, D");
  Console.WriteLine ("O número oculto em B é {0}", bb); 
  resultat1= bb;
  break;
case 'c':
case 'C':
mensagem = ("Agora digite a segunda letra que deseja investigar: A, B, D");
  Console.WriteLine ("O número oculto em C é {0}", cc); 
    resultat1= cc;
  break;
case 'd':
case 'D':
mensagem = ("Agora digite a segunda letra que deseja investigar: A, B, C");
  Console.WriteLine ("O número oculto em D é {0}", dd); 
  resultat1=dd;
  break;
default:
  Console.WriteLine ("Você digitou algo diferente das opções apresentadas e ferrou o jogo. Vamos reiniciar");
  goto inicio;
  // Como termina em goto, não precisa de break

}

Console.WriteLine (mensagem);

essay2=char.Parse(Console.ReadLine());

switch(essay2){
case 'a':
case 'A':
  Console.WriteLine ("O número oculto em A é {0}", aa); 
  resultat2= aa;
  break;
case 'b':
case 'B':
  Console.WriteLine ("O número oculto em B é {0}", bb); 
  resultat2= bb;
  break;
case 'c':
case 'C':
  Console.WriteLine ("O número oculto em C é {0}", cc); 
  resultat2= cc;
  break;
case 'd':
case 'D':
  Console.WriteLine ("O número oculto em D é {0}", dd); 
  resultat2= dd;
  break;
default:
  Console.WriteLine ("Você digitou algo diferente das opções apresentadas e ferrou o jogo. Vamos reiniciar");
  goto inicio;
  // Como termina em goto, não precisa de break
}

  if (resultat1 == resultat2) {
    Console.WriteLine("Acertô, miseravi");
    goto inicio;
  }else {
    Console.WriteLine("Errô, miseravi");
    goto inicio;
  } 
    
    
  }
}