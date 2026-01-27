namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int resultado = numero % 2;

        if (resultado == 0)
        {
            Console.WriteLine("O número é par!");
        }
        else
        {
            Console.WriteLine("O número é ímpar!");
        }
    }
}
