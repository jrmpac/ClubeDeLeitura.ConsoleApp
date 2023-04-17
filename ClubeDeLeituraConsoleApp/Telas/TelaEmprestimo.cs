using ClubeDeLeituraConsoleApp.Modelos;
using ClubeDeLeituraConsoleApp.Repositorio;

namespace ClubeDeLeituraConsoleApp.Telas
{
    public class TelaCadastroEmprestimo
    {
        RepositorioEmprestimo repositorio = new RepositorioEmprestimo();
        List<Emprestimo> lista = new List<Emprestimo>();
        public void MenuEmprestimos()
        {
            bool menuemprestimo = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine(" Clube da Leitura");
            Console.WriteLine("--------------------");
            Console.ResetColor();
            Console.WriteLine();
 
            while (menuemprestimo)
            {
                Console.WriteLine(" --- EMPRESTIMO ---");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastrar Emprestimo");
                Console.WriteLine(" 2 - Editar Emprestimo");
                Console.WriteLine(" 3 - Excluir Emprestimo");
                Console.WriteLine(" 4 - Visualizar Emprestimo");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");
                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    repositorio.CadastrarEmprestimos();
                }
                else if (escolha == "2")
                {
                    repositorio.EditarEmprestimos();
                }
                else if (escolha == "3")
                {
                    repositorio.ExcluirEmprestimos();
                }
                else if (escolha == "4")
                {
                    repositorio.VerificarEmprestimos();
                }
                else if (escolha == "S")
                {
                    menuemprestimo = false;
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
