1. Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e
   escreve o valor de E.
   E = 1 + 1/2 + 1/3 + ... + 1/N

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    int n; double e= 0;
    Console.Write("Informe o valor de N");
    n = Convert.ToInt32(Console.ReadLine());
    for(double i = 1; i<=n; i++){
      e += (1.0/i);
    }
    Console.Write("O valor de E é {0}", e);
}
}
```

2. Escreva um algoritmo que leia 10 valores (usando a mesma variável) e
   encontre o maior e o menor deles. Mostre o resultado.

```cs
internal class Program
{
 private static void Main(string[] args)
 {
   int valor; int menorvalor = 0; int maiorvalor = 0;
   for(int cont = 1; cont <= 10; cont++){
     Console.Write("Escreva uma valor");
     valor = Convert.ToInt32(Console.ReadLine());
     if(cont==1)
     {
       menorvalor = menorvalor + valor;
       maiorvalor = maiorvalor + valor;
   }
   else if(valor>maiorvalor){
       maiorvalor =  valor;
   }
     if (valor<menorvalor){
       menorvalor = valor;
     }
   }
   Console.Write("O menor valor é {0} e o maior valor é {1}", menorvalor, maiorvalor);
     }
   }
```

3. Chico tem 1,50 metros e cresce 2 centímetros por ano, enquanto Zé tem 1,40
   metros e cresce 3 centímetros por ano. Construa um algoritmo que calcule e
   imprima quantos anos serão necessários para que Zé seja maior que Chico.

```cs
internal class Program
{
private static void Main(string[] args)
{
double chico = 1.50; double ze = 1.40; int i=0;
while(ze<chico){
chico = chico + 0.02;
ze = ze + 0.03;
i++;
}
Console.Write("O Tempo necessario para Ze passar Chico é: {0} anos", i);
}
}
```

4. Escreva um algoritmo que leia a matrícula de um aluno e suas três notas.
   Calcule a média ponderada do aluno, considerando que o peso para a maior
   nota seja 4 e para as duas restantes, 3. Mostre ao final a média calculada e
   uma mensagem "APROVADO" se a média for maior ou igual a 5 e
   "REPROVADO" se a média for menor que 5. Repita a operação até que o
   código lido seja negativo.

```cs

internal class Program
{
private static void Main(string[] args)
{
double notas= 0; double maiornota = 0; double media = 0;
for (int i= 0; i!= 3; i++){
Console.Write("Informe sua nota");
notas = Convert.ToDouble(Console.ReadLine());
if (i==0){
maiornota= notas;
}
else if(notas > maiornota){
maiornota=notas;
}
media = media + notas * 3;
}
media = (media + (maiornota*4) - (maiornota\*3))/10;
Console.WriteLine("A media é {0}", media);
if(media >= 5)
Console.Write("APROVADO");
else if (media < 5)
Console.Write("REPROVADO");
}
}
```

5. Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e
   escreve o valor de E.
   E = 1 + 1/1! + 1/2! + 1/3! + ... + 1/N!

```cs
internal class Program
{
private static void Main(string[] args)
{
int num;
Console.Write("Informe o valor de N");
num = Convert.ToInt32(Console.ReadLine());
double e = 1;
for(int i=1; i < num; i++){
e = e + (1.0/CalcularFatorial(i));
}
Console.WriteLine("E = {0}", e);
}

static int CalcularFatorial(int num){
int num1 = num;
int fatorial = 1;
while(num1> 0){
fatorial = fatorial \* num1;
num1--;
}
return fatorial;
}
}
```


