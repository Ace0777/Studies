
1. Faça um programa que leia dois números
inteiros e faça a divisão do primeiro pelo
segundo (se o segundo for diferente de
zero).
```cs
internal class Program
{
  private static void Main(string[] args)
   {
      int x1,x2;
      Console.Write("Informe o Valor 1");
      x1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Informe o Valor 2");
      x2 = Convert.ToInt32(Console.ReadLine());
      if(x2>0 || x2<0)
      {
        int x3;
        x3 = x1/x2;
        Console.Write("A divsão de {0} por {1} é: {2}",x1,x2,x3);
      }
    

   }
}
```
2. Faça um programa para ler dois números
reais e verificar se ambos são maiores que
zero. Caso positivo, informar “Valores são
válidos”. Caso contrário, informar “Valores
inválidos”.

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    int x1,x2;
    Console.Write("Informe o Valor 1");
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o Valor 2");
    x2 = Convert.ToInt32(Console.ReadLine());
    if(x1>0 || x2>0)
    Console.Write("Valores são válidos");
    else if (0>x1 || 0>x2)
    Console.Write("Valores são inválidos");
   }
}
```
3. Tendo como dados de entrada a altura e o
sexo de uma pessoa, construa um
programa que calcule seu peso ideal,
utilizando as seguintes fórmulas:
para homens: (72.7*h)-58
para mulheres: (62.1*h)-44.7

```cs
internal class Program
{
  private static void Main(string[] args)
  {
      char s;
      double a;
      Console.Write("Informe sua altura");
      a = Convert.ToDouble(Console.ReadLine());
      Console.Write("Informe a sua idade:  (m,f)");
      s = Convert.ToChar(Console.ReadLine());
      if (s=='M' || s== 'm')
     {
        double x3;
        x3 = (72.7*a)-58;
        Console.Write("Seu peso ideal é: {0}",x3);
     }
      else if (s== 'F' || s== 'f')
      {
        double x4;
        x4 = (62.1*a)-44.7;
        Console.Write("Seu peso ideal é: {0}",x4);

      }
    }
}
```
4. Faça um programa que leia 3 comprimentos
(x, y e z) e responda se eles formam um
triângulo, ou seja, se
x < y + z e y < x + z e z < x + y.

```cs
internal class Program
{
  private static void Main(string[] args)
  {
      double x,y,z;
      Console.Write("Informe o valor x");
      x = Convert.ToDouble(Console.ReadLine());
      Console.Write("Informe o valor y");
      y = Convert.ToDouble(Console.ReadLine());
      Console.Write("Informe o valor z");
      z = Convert.ToDouble(Console.ReadLine());
    if(x < y + z && y < x + z && z < x + y)
      Console.Write("Triangulo");
    else
       Console.Write("Não é um triangulo");
      
  }
}
```
5. Faça um programa para ler um caractere e
imprimir as seguintes mensagens, segundo o
caso:
• “Sinal de menor”
• “Sinal de maior”
• “Sinal de igual”
• “Outro caractere”

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    char x1;
    Console.Write("Informe um caractere");
    x1 = Convert.ToChar(Console.ReadLine());
    if (x1=='<')
      Console.Write("Sinal de menor");
    else if (x1=='>')
      Console.Write("Sinal de Maior");
    else if (x1=='=')
      Console.Write("Sinal de Igual");
    else 
      Console.Write("Outro caractere");

  }
}
```
6. Elabore um programa que, dada a idade
de um nadador, classifique-o em uma
das seguintes categorias:
• infantil A = 5 – 7 anos
• infantil B = 8 – 10 anos
• juvenil A = 11 – 13 anos
• juvenil B = 14 – 17 anos
• adulto = 18 – 30 anos
• sênior = maiores de 30 anos

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    int x1;
    Console.Write("Informe sua idade");
    x1 = Convert.ToInt32(Console.ReadLine());
    if (x1==5 || x1<=7)
      Console.Write("Infantil A");
    else if (x1==8 || x1<=10)
      Console.Write("Infantil B");
    else if (x1==11 || x1<=13)
      Console.Write("Juvenil A");
    else if (x1==14|| x1<=17)
      Console.Write("Juvenil B");
    else if (x1==18|| x1<=30)
      Console.Write("Adulto");
    else if (x1>=30)
      Console.Write("Senior");

    
  }
}
```

