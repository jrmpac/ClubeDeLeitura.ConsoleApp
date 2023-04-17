using ClubeDeLeituraConsoleApp.Modelos;
using ClubeDeLeituraConsoleApp.Repositorio;
using System;

namespace ClubeDeLeituraConsoleApp.Telas
{
    public class TelaCadastroAmigo
    {
        List<Amigos> listamigos = new List<Amigos>();
        RepositorioAmigos repositorio = new RepositorioAmigos();
        public void MenuAmigos()
        {
            bool menuamigos = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine(" ----- Clube da Leitura -----");
            Console.WriteLine("--------------------");
            Console.ResetColor();
            Console.WriteLine();

            while (menuamigos)
            {
                Console.WriteLine(" --- AMIGOS ---");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastro Amigo");
                Console.WriteLine(" 2 - Editar Amigo");
                Console.WriteLine(" 3 - Excluir Amigo");
                Console.WriteLine(" 4 - Visualizar Amigo");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");
                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    repositorio.CadastrarAmigos(listamigos);
                }
                else if (escolha == "2")
                {
                    repositorio.EditarAmigos(listamigos);
                }
                else if (escolha == "3")
                {
                    repositorio.ExcluirAmigos(listamigos);
                }
                else if (escolha == "4")
                {
                    repositorio.VerificarAmigos(listamigos);
                }
                else if (escolha == "S")
                {
                    menuamigos = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.ResetColor();
                }
            }
        }
    }
}
