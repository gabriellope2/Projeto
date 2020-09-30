using System;

class acessorios{
  //preciso criar uma forma que dps que a classe MOVEL termina a Classe acessorios pergunta se tera algum  acessorio caso nao tenha ja pule para o orcamento
  public static int  gavetas(){
     int gav;

     Console.WriteLine("Quantas gavetas tera o movel?");
     gav = int.Parse(Console.ReadLine());
     
    return gav;
   }
}