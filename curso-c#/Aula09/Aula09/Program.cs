namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("============== OPERADORES LÓGICOS ==============");

        bool isLoggedIn = true;
        bool hasAdminAccess = true;

        Console.WriteLine("\nInformações do usuário!");
        Console.WriteLine("Usuário logado: " + isLoggedIn);
        Console.WriteLine("Acesso de administrador: " + hasAdminAccess);

        // Operador OU || (OR)

        if(isLoggedIn || hasAdminAccess)
        {
            Console.WriteLine("\nAcesso permitido ao sistema!");
        }
        else
        {
            Console.WriteLine("Acesso negado ao sistema!");
        }

        // Operador E && (AND)

        if(isLoggedIn && hasAdminAccess)
        {
            Console.WriteLine("Acesso ao painel de administrador!");
        }
        else
        {
            Console.WriteLine("Acesso negado ao painel de administrador!");
        }

        // Operador de Negação ! (NOT)

        if(!isLoggedIn)
        {
            Console.WriteLine("Usuário não está logado!");
        }
        else
        {
            Console.WriteLine("Usuário está logado!");
        }
    }
}