namespace Aula10;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========== Aula 10 - Calculadora Simples ==========\n");
        
        Console.Write("Digite o primeiro número: ");
        // Convertendo a entrada do usuário para um número de ponto flutuante (double)
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        // Convertendo a entrada do usuário para um número de ponto flutuante (double)
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Exibindo as opções de operações para o usuário escolher
        Console.WriteLine("\nEscolha a operação: ");
        Console.WriteLine("1 - Adição (+)");
        Console.WriteLine("2 - Subtração (-)");
        Console.WriteLine("3 - Multiplicação (*)");
        Console.WriteLine("4 - Divisão (/)");

        Console.Write("\nDigite o número da operação desejada: ");

        // Convertendo a entrada do usuário para um número inteiro (int) para escolher a operação
        int operacao = Convert.ToInt32(Console.ReadLine());

        // Variável para armazenar o resultado da operação
        double resultado = 0;

        // Verificando qual operação o usuário escolheu e realizando o cálculo correspondente
        if(operacao == 1)
        {
            resultado = num1 + num2;
        }
        else if(operacao == 2)
        {
            resultado = num1 - num2;
        }
        else if(operacao == 3)
        {
            resultado = num1 * num2;
        }
        else if(operacao == 4)
        {   
            // Verificando se o segundo número é diferente de zero para evitar divisão por zero
            if(num2 != 0)
            {
                resultado = num1 / num2;
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
            return;
        }

        Console.WriteLine($"\nO resultado da operação é: {resultado}");
    }
}
