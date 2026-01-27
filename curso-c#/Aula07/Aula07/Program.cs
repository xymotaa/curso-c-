namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========== OPERADORES DE ATRIBUIÇÃO ==========\n");

        // Inicialização de variável
        int x = 10;
        Console.WriteLine("O valor inicial de x é: " + x);

        // Operador de atribuição simples
        x = 20;
        Console.WriteLine("\nAtribuição simples (=)");
        Console.WriteLine("O novo valor de x é: " + x);

        // Atribuição composta (Incremento)
        x++;
        Console.WriteLine("\nAtribuição composta (x++)");
        Console.WriteLine("O novo valor de x é: " + x);

        // Atribuição composta (Decremento)
        x--;
        Console.WriteLine("\nAtribuição composta (x--)");
        Console.WriteLine("O novo valor de x é: " + x);

        // Atribuição composta (Adição)
        x += 10;
        Console.WriteLine("\nAtribuição composta (+=)");
        Console.WriteLine("O novo valor de x é: " + x); 

        // Atribuição composta (Subtração)
        x -= 3;
        Console.WriteLine("\nAtribuição composta (-=)");
        Console.WriteLine("O novo valor de x é: " + x);

        // Atribuição composta (Multiplicação)
        x *= 2;
        Console.WriteLine("\nAtribuição composta (*=)");
        Console.WriteLine("O novo valor de x é: " + x);

        // Atribuição composta (Divisão)
        x /= 4;
        Console.WriteLine("\nAtribuição composta (/=)");
        Console.WriteLine("O novo valor de x é: " + x);

        // Atribuição composta (Módulo)
        x %= 3;
        Console.WriteLine("\nAtribuição composta (%=)");
        Console.WriteLine("O novo valor de x é: " + x);

        Console.WriteLine("\n=============================================");
    }
}