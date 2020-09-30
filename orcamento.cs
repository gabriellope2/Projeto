using System;


class final{

  public static float  precoMdf(){
    float preçoM2 ;
    
    Console.WriteLine("Qual o valor do metro quadrado do MDF?");
    preçoM2 = float.Parse(Console.ReadLine());

    return preçoM2;
  }

  public static float  precoCorredica(){
    float corr;
    
    Console.WriteLine("Qual o valor das corrediças?");
    corr = float.Parse(Console.ReadLine());
    
    return corr;
  }

  public static void orcamento(float m2, float areaTotal ,float corredi, int quantgavetas ){
    float total;
  
    total = ((m2 * areaTotal) + (corredi * quantgavetas));
    Console.WriteLine("O preço do movel fica por volta de");
    Console.WriteLine(total);
  }



}