namespace Aula03;

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------------------------------------------");
        const int number = 14;
        number = 75;
        Console.WriteLine("O valor da constante é: " + number);

        Console.WriteLine("--------------------------------------------");
        var idade = 21;
        idade = "Lucas";
        Console.WriteLine("A idade é: " + idade);

        Console.WriteLine("--------------------------------------------");
        var nome = "Flávia";
        nome = 30;
        Console.WriteLine("O nome é: " + nome);

        Console.WriteLine("--------------------------------------------");
        dynamic valor = 21;
        valor = "Maria";
        Console.WriteLine("O valor é: " + valor);
    }
}

/*
O código acima demonstra o uso de constantes, variáveis com tipagem implícita (var) e variáveis dinâmicas (dynamic) em C#.
Vale lembrar que constantes não podem ter seu valor alterado após a atribuição inicial.
Já as variáveis declaradas com 'var' têm seu tipo inferido no momento da atribuição
*/