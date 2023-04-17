using ClubeDeLeituraConsoleApp.Telas;

namespace ClubeDeLeituraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaCadastroAmigo amigos = new TelaCadastroAmigo();

            TelaCadastroEmprestimo emprestimos = new TelaCadastroEmprestimo();

            TelaCadastroRevista revistas = new TelaCadastroRevista();

            TelaCadastroCaixa caixas = new TelaCadastroCaixa();

            bool menuservico = true;
            while (menuservico == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine(" ----- Clube da Leitura ----- ");                
                Console.ResetColor();
                Console.WriteLine();
                
                Console.WriteLine(" (1) Amigos");
                Console.WriteLine(" (2) Emprestimos");
                Console.WriteLine(" (3) Revistas");
                Console.WriteLine(" (4) Caixas");
                Console.WriteLine(" (S) Fechar Programa");
                Console.WriteLine();

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    amigos.MenuAmigos();
                }
                else if (escolha == "2")
                {
                    emprestimos.MenuEmprestimos();
                }
                else if (escolha == "3")
                {
                    revistas.MenuRevistas();
                }
                else if (escolha == "4")
                {
                    caixas.MenuCaixas();
                }
                else if (escolha == "S" )
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Boa Leitura!");
                    Console.ResetColor ();
                    menuservico = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escolha uma opção valida!");
                    Console.ResetColor ();
                }
                Console.ReadKey();
            }
        }
    }
}