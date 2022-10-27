1. Fazer um algoritmo que imprima todos os números
   pares no intervalo de 1 a 100.

```cs
internal class Program
{
  private static void Main(string[] args)
  {
   int x1;
   x1=2;
  while (x1<=100)
 {
  Console.Write("{0} ",x1);
  x1=x1+2;
   }
 }
    }

```

2. Fazer um algoritmo que imprima todos os números de
   100 até 1.

```cs

internal class Program
{
  private static void Main(string[] args)
  {
   int x1 = 100;

  while (x1 >= 1)
  {
    Console.Write("{0} ",x1);
    x1= x1-1;
  }
    }
}

```

3. Ler um número inteiro e positivo e verificar se este é ou
   não um número primo.

```cs

internal class Program
{
  private static void Main(string[] args)
  {
    int num, i, cont = 0;
    Console.Write("Informe um numero inteiro positivo");
    num = Convert.ToInt32(Console.ReadLine());
    for (i=1; num>=i; i++)
    {
      if (num % i == 0)
        cont++;

    }
    if (cont == 2)
        Console.WriteLine("{0} é um numero primo",num);
    else
        Console.WriteLine("{0} Não é um numero primo",num);
    }
    }

```

4. Dada uma dívida de 10000 reais que cresce a juros de
   2,5% ao mês e uma aplicação de 1500 reais com
   rendimento de 4% ao mês, escrever um algoritmo que
   determina o número de meses necessários para pagar
   a dívida.

```cs

internal class Program
{
  private static void Main(string[] args)
  {
      double divida = 10000;
       double aplicacao = 1500;
       int cont = 0;
       while (aplicacao<=divida)
       {
        divida = divida + (10000*0.025);
        aplicacao = aplicacao + (1500*0.04);
        cont++;
       }
        Console.Write("{0} são os meses necessarios para quitar a divida",cont);
    }
}

```

5. Calcular o valor de S:

```cs

internal class Program
{
  private static void Main(string[] args)
  {
    int potencia = 1;
    int subtrair = 50;
    double s = 0;

    while(subtrair>=2)
    {
      s= s + Math.Pow(2,potencia)/subtrair;
      subtrair = subtrair-2;
      potencia = potencia++;
    }
      Console.Write("O valor de S é: {0:N2}",s);

    }
}

```

6- Exercicio extra:

```cs

internal class Program
{
  static int testeidade()
  {
    int idade;
    Console.Write("Informe sua idade");
    idade = Convert.ToInt32(Console.ReadLine());
    while (idade < 0 || idade > 130){
      Console.Write("Idade Invalida!! ");
      Console.Write("Informe sua idade:");
      idade = Convert.ToInt32(Console.ReadLine());
    }
    return idade;
  }
  private static void Main(string[] args)
  {
    Console.Write("Idade informada: {0}", testeidade());
    }
}
```
