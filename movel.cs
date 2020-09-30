using System;

class movel{
  public static float  recebepecas(){
    int n = 0;
    int m = 1;
    int pecass = 0;
    float area = 0;
    float larg;
    float alt;

   Console.WriteLine("quantas peças tera o movel ?");
   pecass = int.Parse(Console.ReadLine());
   Console.WriteLine("coloque as medida em CM ");
   //while para receber a altura e largura das pecas e dps calcular a area total
    while (n < pecass){
      Console.WriteLine("peça");
       Console.WriteLine(m);
      
      Console.WriteLine("Qual a largura da peça?");
       larg = float.Parse(Console.ReadLine());

      Console.WriteLine("Qual a altura da peça");
       alt = float.Parse(Console.ReadLine());


     area += ((larg/100) * (alt/100));       

      m++ ;
      n++ ;
    }
  return area;

  }


}


  

