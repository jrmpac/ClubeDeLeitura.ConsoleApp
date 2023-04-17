using ClubeDeLeituraConsoleApp.Modelos;
using ClubeDeLeituraConsoleApp.Repositorio;

namespace ClubeDeLeituraConsoleApp.Telas
{
    public class TelaCadastroRevista 
    {
        List<Revistas> listarevistas = new List<Revistas>();
        RepositorioRevista repositorio = new RepositorioRevista();
        List<Caixas> listacaixa = new List<Caixas>();
        public void MenuRevistas()
        {
            bool menurevistas = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ====================");
            Console.WriteLine(" Clube da Leitura");
            Console.WriteLine(" ====================");
            Console.ResetColor();
            Console.WriteLine();

            while (menurevistas)
            {

                Console.WriteLine(" === REVISTA ===");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastrar Revista");
                Console.WriteLine(" 2 - Editar Revista");
                Console.WriteLine(" 3 - Excluir Revista");
                Console.WriteLine(" 4 - Visualizar Revista");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    repositorio.CadastrarRevistas(listarevistas);
                }
                else if (escolha == "2")
                {
                    repositorio.EditarRevistas(listarevistas, listacaixa);
                }
                else if (escolha == "3")
                {
                    repositorio.ExcluirRevistas(listarevistas);
                }
                else if (escolha == "4")
                {
                    repositorio.VerificarRevistas(listarevistas);
                }
                else if (escolha == "S")
                {
                    menurevistas = false;
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
