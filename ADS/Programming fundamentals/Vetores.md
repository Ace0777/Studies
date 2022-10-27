1. Desenvolva um programa que leia um vetor de números reais, um escalar e imprima o resultado da multiplicação do vetor pelo escalar.

```cs
internal class Program
    {
        const int tamVet = 5;
        static void Main(string[] args)
        {
            double[] numeros = new double[tamVet];

            for(int i =0;i<tamVet;i++)
            {
                Console.Write("{0} numero de {1}: ", i+1,tamVet);
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Insira o valor do escalar: ");
            double escalar = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Vetor escalar: ");

            for(int i = 0; i<tamVet; i++)
            {
                numeros[i] = numeros[i] * escalar;

                if(i==tamVet-1)
                {
                    Console.Write(numeros[i]);
                }
                else
                {
                    Console.Write("{0}, ",numeros[i]);
                }
            }
        }
    }

```

2. Faça um procedimento que faça a leitura um vetor de 10
   elementos inteiros e imprima somente os valores
   armazenados nos índices pares

```cs
internal class Program
{
  const int tamanhoVet = 10;
  private static void Main(string[] args)
  {
    int [] elementos = new int [tamanhoVet];
    for(int i = 0; i<tamanhoVet; i++)
    {
      Console.Write("Insira o valor {0}/{1}: ",i+1,tamanhoVet);
      elementos[i]=Convert.ToInt32(Console.ReadLine());
    }
    ImprimeElemento(elementos);
  }
  static void ImprimeElemento(int[]elementos)
  {
    for(int i = 0; i<tamanhoVet; i++)
    {
      if(elementos[i]%2==0)
      {
        Console.Write("{0},",elementos[i]);
      }
    }
  }
}
```

3. Faça um programa que leia um vetor com 15 valores reais.
   A seguir, encontre o menor elemento do vetor e a sua
   posição dentro do vetor, mostrando: "O menor elemento do
   vetor está na posição XXXX e tem o valor YYYYY."

```cs
internal class Program
{
  const int tamanhoVet = 15;
  private static void Main(string[] args)
  {
    int [] valor = new int [tamanhoVet];
    int menorvalor = 0;
    int pos = 0;
    for(int i = 0; i<tamanhoVet; i++)
    {
      Console.Write("Insira o valor {0}/{1}: ",i+1,tamanhoVet);
      valor[i]=Convert.ToInt32(Console.ReadLine());
      if(i==0)
      {
        menorvalor = valor[i];
      }
      else if(valor[i]<menorvalor)
      {
        menorvalor= valor[i];
        pos = i;
      }
    }
    Console.Write("O menor valor é {0} e ele se encontra na posição {1}",menorvalor,pos);
  }
}
```

4. Faça um programa que leia um vetor de 15 posições
   (reais) e depois um valor a ser procurado no vetor. Imprima
   se o valor foi ou não encontrado e a quantidade de vezes que
   o valor está presente no vetor.

```cs
internal class Program
{
  const int tamanhoVet = 15;
  private static void Main(string[] args)
  {
    int [] valor = new int [tamanhoVet];
    int x,cont =0;
    for (int i = 0; i<tamanhoVet; i++)
    {
      Console.Write("Valor {0}/{1}: ",i,tamanhoVet);
      valor[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Informe um valor para ser encontrado na matriz: ");
    x = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i<tamanhoVet; i++)
    {
      if(x==valor[i])
      {
        cont++;
      }
      else
      {
        Console.Write("O valor não foi encontrado!");
      }
    }
    Console.Write("O valor {0} foi encontrado {1} vezes na matriz: ",x,cont);
  }
}
```

5. Faça uma função que receba um vetor de números
   inteiros e um valor inteiro. A função deverá procurar este
   segundo valor neste vetor e retornar seu índice se for
   encontrado. Se o elemento não for encontrado, retornar -1.

```cs
using System;

internal class Program
{
  const int tamanhoVet = 5;
  private static void Main(string[] args)
  {
    int[] valor = new int [tamanhoVet];
    int x;
    for (int i = 0; i<tamanhoVet; i++)
    {
      Console.Write("Valor {0}/{1}: ",i+1,tamanhoVet);
      valor[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Informe um valor para ser encontrado na matriz: ");
    x = Convert.ToInt32(Console.ReadLine());

    Console.Write("O valor foi encontrado {0} vezes na matriz: ",ProcuraValor(valor,x));
  }
  static int ProcuraValor(int[] valor,int x)
  {
    int i;
    int contador = 0;
    for ( i = 0; i<tamanhoVet; i++)
    {
      if(x==valor[i])
      {
        contador++;
      }
    }
    if (contador==0)
    {
        return -1;
    }
    else
    {
        return contador;
    }
  }
}
```

6. Dada uma tabela com as notas de uma turma de 20
   alunos, faça funções que retornem:
   a) A média da turma.
   b) a quantidade de alunos aprovados (>=60)
   c) a quantidade de alunos reprovados.(< 60)

```cs
internal class Program
{
  const int tamanhoVet = 20;
  private static void Main(string[] args)
  {
    double[]notas = new double [tamanhoVet];
    double somaNotas = 0;
    for (int i = 0; i<tamanhoVet; i++)
    {
      Console.Write("Informe a nota {0}/{1}: ",i+1,tamanhoVet);
      notas[i] = Convert.ToDouble(Console.ReadLine());
      somaNotas += notas[i];
    }
    Console.WriteLine("A media da turma é {0}",MediaTurma(somaNotas));
    Console.WriteLine("A quatidade de alunos aprovados são: {0}",AprovadosTurma(notas));
    Console.WriteLine("A quatidade de alunos reprovados são: {0}",ReprovadosTurma(notas));

  }
  static double MediaTurma(double somaNotas)
  {
    double media = somaNotas/(double)tamanhoVet;
    return media;
  }

  static double AprovadosTurma(double[]notas)
  {
    int contAprovados = 0;
    for(int i = 0; i<tamanhoVet; i++)
    {
      if(notas[i]>=60)
      {
       contAprovados++;
      }
    }
    return contAprovados;
  }

  static double ReprovadosTurma(double[]notas)
  {
    int contReprovados = 0;
    for(int i = 0; i<tamanhoVet; i++)
    {
      if(notas[i]<60)
      {
       contReprovados++;
      }
    }
    return contReprovados;
  }
}
```

7. Faça um programa que leia um conjunto de 20 valores e
   armazene-os num vetor V. Particione-o em dois outros
   vetores, P e I, conforme os valores de V forem pares ou
   ímpares. No final, imprima os valores dos 3 vetores.

```cs
    class Program
    {
        const int tamanho = 20;
        static void Main(string[] args)
        {
            int[] valores = new int[tamanho];
            int pcont=0,icont=0;
            for(int i=0; i<tamanho; i++)
            {
                Console.Write("{0} de {1}: ",i+1,tamanho);
                valores[i] = Convert.ToInt32(Console.ReadLine());

                if(valores[i] % 2 == 0)
                {
                    pcont++;
                }
                else
                {
                    icont++;
                }
            }
            int[] pares = new int[pcont];
            int[] impares = new int[icont];
            int j=0,x=0;

            for(int i = 0; i < valores.Length; i++)
            {
                if(valores[i] % 2 == 0)
                {
                    pares[j] = valores[i];
                    j++;
                }
                else
                {
                    impares[x] = valores[i];
                    x++;
                }
            }
            Console.Write("\nValor do vetor V: ");
            for(int i = 0; i < valores.Length;i++)
            {
                if(i==valores.Length-1)
                {
                    Console.Write(valores[i]);
                }
                else
                {
                    Console.Write(valores[i] + ",");
                }
            }
            Console.Write("\nValor do vetor impares: ");
            for(int i = 0; i < impares.Length;i++)
            {
                if(i==impares.Length-1)
                {
                    Console.Write(impares[i]);
                }
                else
                {
                    Console.Write(impares[i] + ",");
                }
            }
            Console.Write("\nValor do vetor pares: ");
            for(int i = 0; i < pares.Length;i++)
            {
                if(i==pares.Length-1)
                {
                    Console.Write(pares[i]);
                }
                else
                {
                    Console.Write(pares[i] + ",");
                }
            }
        }
    }
```

8/9) Faça um programa que leia um vetor G[13] que é o
gabarito de um teste da loteria esportiva, contendo os valores
1 quando for coluna 1, 0 quando for coluna do meio e 2
quando for coluna 2.
Ler a seguir, para 5 apostadores, seu cartão de apostas
(R[13]) e depois da leitura imprimir quantos acertos o
apostador teve.
Faça o teste através de funções.

```cs
internal class Program
{
  const int tamanhoVet = 5;
  private static void Main(string[] args)
  {
    int [] g13 = new int [tamanhoVet];
    int [] candidato = new int [tamanhoVet];
    for (int i = 0; i < tamanhoVet; i++)
    {
      Console.Write("Informe o resultado da loteria {0}/{1}: ",i+1,tamanhoVet);
      g13[i] = Convert.ToInt32(Console.ReadLine());
    }
     for(int i = 0; i<candidato.Length; i++)
    {
      candidato[i]=AcertoLoteria(g13);
    }
    for(int i = 0; i<candidato.Length; i++)
    {
    Console.Write("Apostador {0}: Você Acertou {1}",candidato[i],AcertoLoteria(g13));
    }
  }

  static int AcertoLoteria(int [] g13)
  {
    int contr3 = 0;
    int [] r3 = new int [tamanhoVet];
    for (int i = 0; i<tamanhoVet; i++)
    {
      Console.Write("Usuario {0}: Informe os numeros {1}/{2}: ",i+1,tamanhoVet);
       r3[i] = Convert.ToInt32(Console.ReadLine());
       if (r3[i]==g13[i])
      {
      contr3++;
      }
    }
     return contr3;
  }
}
```

10. Faça um programa que leia um vetor de valores inteiros e
    imprima-o na ordem crescente. O vetor deve ter tamanho N
    (declare e utilize uma constante N)

```cs
nternal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Informe o tamnho do vetor: ");
    int tamanhoVet = Convert.ToInt32(Console.ReadLine());
    int [] valores = new int [tamanhoVet];
    for(int i = 0; i<valores.Length; i++)
    {
      Console.Write("Valores do vetor {0}/{1}: ",i+1,tamanhoVet);
      valores[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i = 0; i<tamanhoVet; i++)
    {
      Console.Write("{0}",valores[i]);
    }
    Console.WriteLine();
    ImprimeCrescente(valores,tamanhoVet);
  }


  static void ImprimeCrescente(int[]valores,int tamanhoVet)
  {
    int j,aux;
    for (j = 0; j<tamanhoVet; j++)//faz varias vezes o teste
    {
      for (int i = 0; i<tamanhoVet-1; i++)//-1 pois se meu vetor tem tamanho 5 o ultimo elemento está na posição 4, indo até o elemento 3 pra comparar com o elemento 4
      {
        if (valores[i] > valores [i+1])
        {
          aux = valores[i];
          valores[i]=valores[i+1];
          valores[i+1]=aux;
        }
      }
    }
    for(int i = 0; i<tamanhoVet; i++)
    {
      Console.Write("{0}",valores[i]);
    }
  }
}
```
