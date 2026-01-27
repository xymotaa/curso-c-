namespace Aula08;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("================= OPERADORES RELACIONAIS =================");
        
        Console.Write("Digite o primeiro número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int y = Convert.ToInt32(Console.ReadLine());

        string resultado;

        // Operador de igualdade (==)
        if(x == y)
        {
            resultado = "X é igual a Y";
        }
        else
        {
            resultado = "X não é igual a Y";
        }

        Console.Write("\nIgualdade (==): " + resultado);

        // Operador de diferença (!=)
        if(x != y)
        {
            resultado = "X é diferente de Y";
        }
        else
        {
            resultado = "X não é diferente de Y";
        }

        Console.Write("\nDiferença (!=): " + resultado);

        // Operador maior que (>)
        if(x > y)
        {
            resultado = "X é maior que Y";
        }
        else
        {
            resultado = "X não é maior que Y";
        }

        Console.Write("\nMaior que (>): " + resultado);

        // Operador menor que (<)
        if(x < y)
        {
            resultado = "X é menor que Y";
        }
        else
        {
            resultado = "X não é menor que Y";
        }

        Console.Write("\nMenor que (<): " + resultado);

        // Operador maior ou igual a (>=)
        if(x >= y)
        {
            resultado = "X é maior ou igual a Y";
        }
        else
        {
            resultado = "X não é maior ou igual a Y";
        }

        Console.Write("\nMaior ou igual a (>=): " + resultado);

        // Operador menor ou igual a (<=)
        if(x <= y)
        {
            resultado = "X é menor ou igual a Y";
        }
        else
        {
            resultado = "X não é menor ou igual a Y";   
        }

        Console.Write("\nMenor ou igual a (<=): " + resultado);

        Console.WriteLine("\n=========================================================");
    }
}
