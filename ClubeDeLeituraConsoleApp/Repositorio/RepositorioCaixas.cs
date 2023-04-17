using ClubeDeLeituraConsoleApp.Modelos;

namespace ClubeDeLeituraConsoleApp.Repositorio
{
    public class RepositorioCaixas
    {
        public void CadastrarCaixas(List<Caixas> ListaCaixas)
        {
            Caixas caixa = new Caixas();

            Console.WriteLine("Qual a cor da caixa: ");
            caixa.corcaixa = Console.ReadLine();

            Console.WriteLine("Qual a etiqueta da caixa: ");
            caixa.etiqueta = Console.ReadLine();

            caixa.ID = ListaCaixas.Count;

            ListaCaixas.Add(caixa);

            Console.WriteLine("Cadastro feito com sucesso.");
        }

        public void EditarCaixas(List<Caixas> ListaCaixas)
        {
            Caixas caixa = new Caixas();

            Console.Write("Qual ID gostaria de Editar: ");
            caixa.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaCaixas.FindIndex(item => caixa.remove == item.ID);
            ListaCaixas.RemoveAt(index);

            Console.Write("Qual a cor da caixa: ");
            caixa.corcaixa = Console.ReadLine();

            Console.Write("Qual a etiqueta da caixa: ");
            caixa.etiqueta = Console.ReadLine();

            caixa.ID = ListaCaixas.Count;

            caixa.ID--;

            ListaCaixas.Add(caixa);

            Console.WriteLine("Edição feita com sucesso.");
        }

        public void ExcluirCaixas(List<Caixas> ListaCaixas)
        {
            Caixas caixa = new Caixas();

            Console.Write("Qual ID gostaria de Excluir: ");
            caixa.remove = Convert.ToInt32(Console.ReadLine());

            int index = caixa.teste.FindIndex(item => caixa.remove == item.ID);
            caixa.teste.RemoveAt(index);

            Console.WriteLine("Exclusão feita com sucesso.");
        }

        public void VerificarCaixas(List<Caixas> ListaCaixas)
        {
            Console.WriteLine();

            Caixas caixa = new Caixas();

            // Console.WriteLine("ID - Cor da Caixa - Etiqueta");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" |{0,-10} | {1,-30} | {2, -30}|", "Id", "Cor da Caixa", "Etiqueta");

            Console.WriteLine(" |----------------------------------------------------------------------------|");

            foreach (Caixas item in ListaCaixas)
            {
                Console.WriteLine(" |{0,-10} | {1,-30} | {2,-30}|", item.ID, item.corcaixa, item.etiqueta);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
