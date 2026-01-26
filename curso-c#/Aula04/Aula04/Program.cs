namespace Program;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=============== TELA DE CADASTRO ===============");
        Console.WriteLine();

        Console.Write("Nome completo: ");
        string nomeCompleto = Console.ReadLine()!;

        Console.Write("Nome de usuário: ");
        string nomeUsuario = Console.ReadLine()!;

        Console.Write("Idade: ");
        int idade = Convert.ToInt32(Console.ReadLine()!);

        Console.Write("E-mail: ");
        string email = Console.ReadLine()!;

        Console.Write("Endereço: ");
        string endereco = Console.ReadLine()!;

        Console.Write("Estado civil (Solteiro(a), Casado(a), Divorciado(a), Viúvo(a)): ");
        string estadoCivil = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine("=============== CADASTRO REALIZADO ===============");
        Console.WriteLine();

        Console.WriteLine("Usuário: " + nomeUsuario);
        Console.WriteLine("Nome completo: " + nomeCompleto);
        Console.WriteLine("Idade: " + idade + " anos");
        Console.WriteLine("E-mail: " + email);
        Console.WriteLine("Endereço: " + endereco);
        Console.WriteLine("Estado civil: " + estadoCivil);

        Console.WriteLine();
        Console.WriteLine("===============================================");
    }
}
