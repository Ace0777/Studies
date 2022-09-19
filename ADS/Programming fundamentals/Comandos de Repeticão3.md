6. Faça um programa que, dado um conjunto de valores inteiros e positivos
   (fornecidos um a um pelo usuário), determine qual o menor valor do conjunto.
   O final do conjunto de valores é conhecido através do valor zero, que não
   deve ser considerado.

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    int n;
    int valor = 0;
    int menorvalor = 0;
    Console.Write("Informe quantos conjuntos você deseja ");
    n = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i!=n; i++){
      Console.Write("Informe um valor:");
      valor = Convert.ToInt32(Console.ReadLine());
      if (i == 0){
        menorvalor = valor;
      }
      else if(valor<=menorvalor){
        menorvalor = valor;
      }
      }
        Console.Write("O menor valor é: {0}",menorvalor);
    }

}
```

7. A conversão de graus Fahrenheit para Centígrados é obtida pela fórmula
   C = 5/9(F – 32). Escreva um programa que calcule e escreva uma tabela de
   graus centígrados em função de graus Fahrenheit que variem de 50 a 150 de
   1 em 1.

```cs
internal class Program
{
private static void Main(string[] args)
{
for(int i = 0; i<=150; i++){
Console.WriteLine("{0}°F em °C: {1:N2}", i, ((i-32)/(1.8)));
}
}
}
```

8. Elabore um programa que calcule N! (fatorial de N), sendo que o valor inteiro
   de N é fornecido pelo usuário. Sabendo que:
   N! = N x (N-1) x (N-2) x ... x 3 x 2 x 1;
   0! = 1, por definição

```cs
internal class Program
{
private static void Main(string[] args)
{
int n, fatorial = 1;
Console.Write("Informe o valor de N: ");
n = Convert.ToInt32(Console.ReadLine());
while(n>0){
fatorial = fatorial\*n;
n--;
}
Console.Write("O Fatorial de {0} é: {1}", n,fatorial);
}
}
```

9. Fazer um programa para calcular e mostrar os N primeiros termos da série
   de Fibonacci. O número N é fornecido pelo usuário. A série de Fibonacci é
   gerada da seguinte forma:
   f1 = f2 = 1;
   f3 = f1 + f2 = 2;
   f4 = f2 + f3 = 3;....
   O primeiro e segundo termos valem 1 e os seguintes são calculados
   somando os dois termos anteriores.

```cs
internal class Program
{

// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
private static void Main(string[] args)
{
int f1 = 0;
int f2 = 0;
int x1 = 0;
int n;
Console.Write("Informe o valor de N: ");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++){
Console.WriteLine("A sequencia é: {0} ",f1);
if(f1==0){
f1=1;
}
else{
x1 = f1; //1,1,2,3,5
f1 = f1 + f2; // 1,2,3,5,8,13
f2 = x1; // 1,2,3,5,8,13
}
}
}
}
```


