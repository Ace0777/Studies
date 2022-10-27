1. Fazer um programa para contar o número de espaços em
   branco de uma string

```cs
internal class Program
{
  private static void Main(string[] args)
  {
      string palavra = Console.ReadLine();
      int cont = 0;
      for(int i = 0; i < palavra.Length; i++)
      {
        if(palavra[i] == ' ')
        {
          cont++;
        }
      }
      Console.Write("O numero de espaços vazios da palavra {0} é: {1}",palavra,cont);
  }
}
```

2. Refaça o programa anterior criando uma função que
   receberá como parâmetro a string e retornará o número de
   espaços em branco que a string contém.

```cs
internal class Program
{
  private static void Main(string[] args)
  {
      Console.Write("Palavra: ");
      string palavra = Console.ReadLine();
      Console.Write("O numero de espaços vazios da palavra é: {0}",ContaEspacos(palavra));
  }

  static int ContaEspacos(string palavra)
  {
       int cont = 0;
      for(int i = 0; i < palavra.Length; i++)
      {
        if(palavra[i] == ' ')
        {
          cont++;
        }
      }
      return cont;
  }
}
```

3. Fazer um programa para contar o número de vogais em
   uma string.

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Escreva algumas palavras: ");
    string texto = Console.ReadLine();
    int cont = 0;

    for(int i = 0; i < texto.Length; i++)
    {
      if((texto[i]=='a')||(texto[i]=='i')||(texto[i]=='e')||(texto[i]=='o')||(texto[i]=='u'||(texto[i]=='A')||(texto[i]=='I')||(texto[i]=='E')||(texto[i]=='O')||(texto[i]=='U')))
      {
        cont++;
      }
    }
    Console.Write("A palvra {0} possui {1} vogais",texto,cont);
  }
}
```

4. Refaça o programa anterior criando uma função que
   receberá como parâmetro a string e retornará o número de
   vogais que a string contem.

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Escreva algumas palavras: ");
    string texto = Console.ReadLine();
    int cont = 0;

    Console.Write("A palvra possui {0} vogais",ContaVogais(texto));
  }

  static int ContaVogais(string texto)
  {
    int cont = 0;
    for(int i = 0; i < texto.Length; i++)
    {
      if((texto[i]=='a')||(texto[i]=='i')||(texto[i]=='e')||(texto[i]=='o')||(texto[i]=='u'||(texto[i]=='A')||(texto[i]=='I')||(texto[i]=='E')||(texto[i]=='O')||(texto[i]=='U')))
      {
        cont++;
      }
    }
    return cont;
  }
}
```

5. Escreva um programa para ler uma string (com mais de
   uma palavra) e imprimi-la de forma que a primeira letra de
   cada palavra fique em maiúscula. Para isso, basta subtrair
   32 do elemento que deseja alterar para maiúsculo.
   Console.Write("{0} ", Convert.ToChar(chrNomeRecebido[i] – 32));
   ou
   Console.Write("{0} ", Convert.ToChar(chrNomeRecebido[i] – 'a' + 'A' ));
   Exemplo:
   Entrada: lab. de linguagem de programacao
   Impressão: Lab. De Linguagem De Programacao

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Informe o texo a ser convertido: ");
    string texto = Console.ReadLine();

    Console.Write(ConverteParaMaiuscula(texto[0]));

    for(int i = 1; i < texto.Length; i++)
    {
      if(texto[i-1] == ' ')
      {
        Console.Write(ConverteParaMaiuscula(texto[i]));
      }
      else
      {
        Console.Write(texto[i]);
      }
    }
    Console.WriteLine();
  }

  static char ConverteParaMaiuscula (char c)
  {
    if(ConverteParaMinuscula(c))
      return Convert.ToChar(c - 'a' + 'A');

    return c;
  }

  static bool ConverteParaMinuscula (char c)
  {
    return c >= 'a' && c <= 'z';
  }
}
```

6. Crie um procedimento que receba uma frase e a exiba na
   tela de forma soletrada, ou seja, cada letra deve ser
   exibida na tela separada por hífen.

```cs
internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Insira a frase: ");
    string frase = Console.ReadLine();

    FraseComHifen(frase);
  }

  static void FraseComHifen(string frase)
  {
    for(int i = 0; i < frase.Length; i++)
    {
      if (i == frase.Length -1 || frase[i+1] == ' ')
      {
        Console.Write(frase[i]);
      }
      else if(frase[i] != ' ')
      {
        Console.Write(frase[i]+"-");
      }
      else
      {
        Console.Write(" ");
      }
    }
  }
}
```
7) Crie um procedimento que receba uma string e imprima a
string invertida.
Exemplo:
Entrada: Teste
Saída: etseT
```cs
internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Insira uma palavra: ");
    string palavra = Console.ReadLine();

    ImprimeInvertida(palavra);
  }

  static void ImprimeInvertida(string palavra)
  {
    for(int i = palavra.Length -1; i >= 0; i--)
    {
      Console.Write(palavra[i]);
    }
  }
}
```

