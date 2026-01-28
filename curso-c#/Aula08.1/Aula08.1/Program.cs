namespace Aula8_1;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=============== OPERADORES RELACIONAIS ===============");

        Console.Write("\nDigite um ano de nascimento (A) (YYYY): ");
        int Data1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite um ano qualquer (B) (YYYY): ");
        int Data2 = Convert.ToInt32(Console.ReadLine());

        string result;

        // Operador de comparação de igualdade (==)
        // Ele testa se os valores são iguais
        // O resultado é um booleano, verdadeiro ou falso

        if (Data1 == Data2)
        {
            result = $"A data informada (A) {Data1} é igual a data informada (B) {Data2}";
        }
        else
        {
            result = $"A data informada (A) {Data1} é diferente da data informada (B) {Data2}";
        }

        Console.WriteLine("\nO resultado utilizando o operador de igualdade (==) é: " + result);

        // Operador de comparação de diferença (!=)
        // Ele testa se os valores são diferentes
        // O resultado é um booleano, ele retorna verdadeiro se forem diferentes e falso se forem iguais

        if (Data1 != Data2)
        {
            result = $"A data informada (A) {Data1} é diferente da data informada (B) {Data2}";
        }
        else
        {
            result = $"A data informada (A) {Data1} é igual a data informada (B) {Data2}";
        }

        Console.WriteLine("O resultado utilizando o operador de diferença (!=) é: " + result);

        // Operador de comparação maior que (>)

        if (Data1 > Data2)
        {
            result = $"A data informada (A) {Data1} é maior que a data informada (B) {Data2}";
        }
        else
        {
            result = $"A data informada (A) {Data1} não é maior que a data informada (B) {Data2}";
        }

        Console.WriteLine("O resultado utilizando o operador maior que (>) é: " + result);

        // Operador de comparação menor que (<)

        if (Data1 < Data2)
        {
            result = $"A data informada (A) {Data1} é menor que a data informada (B) {Data2}";
        }
        else
        {
            result = $"A data informada (A) {Data1} não é menor que a data informada (B) {Data2}";
        }

        Console.WriteLine("O resultado utilizando o operador menor que (<) é: " + result);

        // Operador de comparação maior ou igual (>=)

        if (Data1 >= Data2)
        {
            result = $"A data informada (A) {Data1} é maior ou igual a data informada (B) {Data2}";
        }
        else{
            result = $"A data informada (A) {Data1} é menor ou igual a data informada (B) {Data2}";
        }
        
        Console.WriteLine("O resultado utilizando o operador maior ou igual (>=) é: " + result);
        
        // Operador de comparação menor ou igual (<=)
        
        if (Data1 <= Data2)
        {
            result = $"A data informada (A) {Data1} é menor ou igual a data informada (B) {Data2}";
        }
        else
        {
            result = $"A data informada (A) {Data1} é maior ou igual a data informada (B) {Data2}";
        }
        
        Console.WriteLine("O resultado utilizando o operador menor ou igual (<=) é: " + result);

        Console.WriteLine("\n=====================================================");
    }
}
