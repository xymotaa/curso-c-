using System.Diagnostics;

namespace Aula;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Aula de Variáveis em C#");
        // STRING
        string Nome = "Flávia Silva";
        // DOUBLE
        double Altura = 1.70;
        // INT 
        int Idade = 21;
        // BOOL
        bool Estudante = true;
        // CHAR
        char Sexo = 'F';

        Console.WriteLine("Olá, meu nome é " + Nome);
        Console.WriteLine("Tenho "+ Idade + " anos de idade");
        Console.WriteLine("Minha altura é " + Altura + "m");
        Console.WriteLine("É estudante? " + Estudante);
        Console.WriteLine("Sexo: " + Sexo);
        Console.WriteLine("Fima da aula de variáveis em C#!");
        Console.WriteLine("-------------------------------");
    }
}

/*
    Bom, vale lembrar que em C# as variáveis são fortemente tipadas, ou seja,
    você deve declarar o tipo da variável no momento da criação dela. Além disso, C# é uma linguagem case-sensitive,
    o que significa que "nome" e "Nome" seriam consideradas variáveis diferentes.

    Os tipos de dados mais comuns em C# incluem:
    - string: para texto
    - int: para números inteiros
    - double: para números de ponto flutuante
    - bool: para valores booleanos (true/false)
    - char: para um único caractere 

    A diferença entre variáveis e constantes em C# é que as variáveis podem ter seu 
    valores alterados durante a execução do programa, enquanto as constantes são declaradas.

*/
