using ClubeDeLeituraConsoleApp.Modelos;
using ClubeDeLeituraConsoleApp.Repositorio;

namespace ClubeDeLeituraConsoleApp.Telas
{
    public class TelaCadastroCaixa
    {
        RepositorioCaixas repositorio = new RepositorioCaixas();
        List<Caixas> lista = new List<Caixas>();
        public void MenuCaixas()
        {
            bool menucaixas = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ====================");
            Console.WriteLine(" Clube da Leitura");
            Console.WriteLine(" ====================");
            Console.ResetColor();
            Console.WriteLine();

            while (menucaixas)
            {
                Console.WriteLine(" === Caixa ===");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastrar Caixa");
                Console.WriteLine(" 2 - Editar Caixa");
                Console.WriteLine(" 3 - Excluir Caixa");
                Console.WriteLine(" 4 - Visualizar Caixa");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");

                string escolha = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (escolha == "1")
                {
                    repositorio.CadastrarCaixas(lista);
                }
                else if (escolha == "2")
                {
                    repositorio.EditarCaixas(lista);
                }
                else if (escolha == "3")
                {
                    repositorio.ExcluirCaixas(lista);
                }
                else if (escolha == "4")
                {
                    repositorio.VerificarCaixas(lista);
                }
                else if (escolha == "S")
                {
                    menucaixas = false;
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

