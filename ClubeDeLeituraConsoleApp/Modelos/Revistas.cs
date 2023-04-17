namespace ClubeDeLeituraConsoleApp.Modelos
{
    public class Revistas
    {
        public String titulo { get; set; }  
        public string colecao { get; set; }
        public string edicao { get; set; }
        public string ano { get; set; }
        public int ID { get; set; }
        public int remove { get; set; }
        public int caixaescolhida { get; set; }
        public int IdCaixaEscolhida { get; set; }
        public bool achou { get; set; }
    }
}
