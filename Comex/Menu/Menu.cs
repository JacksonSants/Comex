namespace Comex.Menu;

public class Menu
{
    internal static void ExibirLogo()
    {
        string welcome = "Welcome to Comex";
        void ExibirLogo()
        {
            Console.WriteLine(@"
        ░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
        ██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
        ██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
        ██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
        ╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
          ░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");
            Console.WriteLine(welcome);
        }

    }
}
