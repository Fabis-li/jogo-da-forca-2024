namespace JogoDaForca.ConsoleApp
{
    public class JogoDaForca
    {
        string[] palavrasSecretas = {
            "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARAÇA", "BACABA", "BACURI", "BANANA", "CAJA",
            "CAJU", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA",
            "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI",
            "TANGERINA", "UMBU", "UVA", "UVAIA"
        };


        private Random random = new Random();
        private string palavraSelecionada;
        private Palavra palavra;
        private Jogador jogador;

        public void IniciarJogo()
        {
            palavraSelecionada = palavrasSecretas[random.Next(0, palavrasSecretas.Length)];
            palavra = new Palavra(palavraSelecionada);
            jogador = new Jogador();

            while (!palavra.LetrasReveladas() && jogador.TentativasRestantes > 0)
            {
                Console.Clear();
                DesenharForca(jogador.TentativasRestantes);
                Console.WriteLine(palavra.PalavraOculta());
                Console.WriteLine($"Letras tentadas: {jogador.LetrasTentadas()}");
                Console.WriteLine("Qual o seu chute? ");
                char letra = Console.ReadLine().ToUpper()[0];

                if (!jogador.Chute(letra))
                {
                    Console.WriteLine("Letra inválida ou já tentada.");
                    Console.WriteLine("Pressione Enter para continuar.");
                    Console.ReadLine();
                }
                else if (palavra.RevelarLetra(letra))
                {                    
                    palavra.RevelarLetra(letra);
                }
                else                       
                    jogador.DecrementarTentativas();
                    
            }
            Console.Clear();
            DesenharForca(jogador.TentativasRestantes);

            if (palavra.LetrasReveladas())
            {
                Console.WriteLine("Parabéns, você acertou a palavra!");
            }
            else
            {                
                Console.WriteLine("Você perdeu!");
                Console.WriteLine($"A palavra era: {palavraSelecionada}");
            }
        }       

        public void DesenharForca(int erros)
        {
            switch (erros)
            {
                case 0:
                    Console.WriteLine(" -----------");
                    Console.WriteLine(" |/        |");
                    Console.WriteLine(" |         o");
                    Console.WriteLine(" |        /x\\");
                    Console.WriteLine(" |         x");
                    Console.WriteLine(" |        / \\");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine("_|____      ");
                    break;

                case 1:
                    Console.WriteLine(" -----------");
                    Console.WriteLine(" |/        |");
                    Console.WriteLine(" |         o");
                    Console.WriteLine(" |        /x\\");
                    Console.WriteLine(" |         x");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine("_|____      ");
                    break;

                case 2:
                    Console.WriteLine(" -----------");
                    Console.WriteLine(" |/        |");
                    Console.WriteLine(" |         o");
                    Console.WriteLine(" |        /x");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine("_|____      ");
                    break;

                case 3:
                    Console.WriteLine(" -----------");
                    Console.WriteLine(" |/        |");
                    Console.WriteLine(" |         o");
                    Console.WriteLine(" |        / ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine("_|____      ");
                    break;

                case 4:
                    Console.WriteLine(" -----------");
                    Console.WriteLine(" |/        |");
                    Console.WriteLine(" |         o");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine("_|____      ");
                    break;

                case 5:
                    Console.WriteLine(" -----------");
                    Console.WriteLine(" |/        |");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine(" |          ");
                    Console.WriteLine("_|____      ");
                    break;
            }
        }
    }
}
