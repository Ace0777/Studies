/* internal class Program
{
 static void Main(string[] args)
        {
            int x;
            Console.Write("Informe um numero");
            x=Convert.ToInt32(Console.ReadLine());
            if(x%2==0 && x%3==0 & x%5!=0)
            {
                Console.Write("ele é divisivel");
            }
            else
            {
                Console.Write("ele não é divisivel");
            }
        
    
        }
    }
  
internal class Program
{
  private static void Main(string[] args)
  {
    int x;
    Console.Write("Informe um dia");
    x = Convert.ToInt32(Console.ReadLine());
    if (x == 1)
    {
       Console.Write("Domingo");
    }
    else if (x==2)
    {
       Console.Write("Segunda");
    }
    else if (x==3){
       Console.Write("terça");
    }
    else if (x==7){
       Console.Write("Domingo");
    }
    
internal class Program
{
  private static void Main(string[] args)
  {
    int x1;
    Console.Write("Informe sua idade");
    x1 = Convert.ToInt32(Console.ReadLine());
    if (x1<13)
    Console.Write("criança");
    else if (x1<=13 || x1<20)
    Console.Write("Adolescente");
    else if (x1<=20 || x1<60)
    Console.Write("Adulto");
    else if (x1>=60)
    Console.Write("Idoso");
    }
}

internal class Program
{
  private static void Main(string[] args)
  {
    int x1;
    Console.Write("Escreva o numero do seu codigo");
    x1 = Convert.ToInt32(Console.ReadLine());
    if (x1>=1 && x1<20)
    Console.Write("Europa");
    else if (x1>=21 && x1<40)
    Console.Write("Ásia");
  }
}

internal class Program
{
  private static void Main(string[] args)
  {
    int x1, x2;
    char op;
    Console.Write("Informe um numero:  ");
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe outro numero:  ");
    x2 = Convert.ToInt32(Console.ReadLine());
    

    Console.Write("Informe a operação (+,-,* ou /):  ");
    op = Convert.ToChar(Console.ReadLine());
    if(op== '-'){
        int result1;
        result1 = x1-x2;
        Console.Write("O resultado da subtração é {0}", result1);
    }
    else if (op == '+'){
        int result2;
        result2 = x1+x2;
        Console.Write("O resultado da subtração é {0}", result2);

    }
    }
}
*/
internal class Program
{
  private static void Main(string[] args)
  {
    string fp;
    Console.Write("Informe a forma de pagamento: A vista, em três vezes.");
    fp = Console.ReadLine(); /* não precisa converter pq o metodo redline é string */
    if (fp=="A vista")
   {
    Console.Write("20% De desconto");
    }
    
    
}
}