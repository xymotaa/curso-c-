namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("============= Calculadora ============= \n");

        Console.Write("Digite o primeiro numero: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo numero:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        int soma = number1 + number2;
        int subtracao = number1 - number2;
        int multiplicacao = number1 * number2;
        int divisao = number1 / number2;
        int modulo = number1 % number2;

        Console.WriteLine("============= Resultados ============== \n");

        Console.WriteLine("A soma do numero 1 com o numero 2 é:" + soma);
        Console.WriteLine("A subtraçao do numero 1 com o numero 2 é: " + subtracao);
        Console.WriteLine("A multiplicação do numero 1 com o numero 2 é: " + multiplicacao);
        Console.WriteLine("A divisão do numero 1 com o numero 2 é: " + divisao);
        Console.WriteLine("O modulo do numero 1 com o numero 2 é: " + modulo);

        Console.WriteLine("");
        
        Console.WriteLine("=======================================");
    }
}