namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavrasSecretas =
            {
               "ABACATE","ABACAXI","ACEROLA","ACAI","ARACA","BACABA","BACURI","BANANA","CAJÁ","CAJÚ",
               "CARAMBOLA","CUPUACU","GRAVIOLA","GOIABA","jABUTICABA","JENIPAPO","MACA","MANGABA","MANGA",
               "MARACUJA","MURICI","PEQUI","PITANGA","PITAYA","SAPOTI","TANGERINA","UMBU","UVA","UVAIA"
            };

            Random random = new Random();
            string palavraSelecionada = palavrasSecretas[random.Next(0, palavrasSecretas.Length)];

            char[] letrasCertas = new char[palavraSelecionada.Length];
            for (int i = 0; i < letrasCertas.Length; i++)
            {
                letrasCertas[i] = '_'; 

            }

            int qtdeTentativasIniciais = 5;
            int tentativasRestantes = 5;
            char[] letrasTentadas = new char[26];

            for (int tentativa = 0; tentativa < qtdeTentativasIniciais; tentativa++)
            {
                DesenharForca(tentativasRestantes);
                Console.WriteLine(string.Join(" ", letrasCertas));
                Console.WriteLine("Letras tentadas: " + string.Join(" ", letrasTentadas));
                Console.Write("Qual o seu chute ? ");
                char letra = Console.ReadLine().ToUpper()[0];
                Console.WriteLine();


                if (!char.IsLetter(letra))
                {
                    Console.WriteLine("Digite apenas letras");
                    tentativasRestantes--;
                    Console.Clear();
                    continue;
                }

                if (Array.IndexOf(letrasTentadas, letra) != -1)
                {
                    Console.WriteLine("Você já digitou essa letra");
                    tentativasRestantes--;
                    Console.Clear();
                    continue;
                }

                letrasTentadas[25 - (int)('Z' - letra)] = letra;

                bool acertou = false;
                for (int i = 0; i < palavraSelecionada.Length; i++)
                {
                    if (palavraSelecionada[i] == letra)
                    {
                        letrasCertas[i] = letra;
                        acertou = true;
                        tentativa--;
                    }
                    Console.Clear();
                }


                if (!acertou)
                {
                    Console.WriteLine("Letra Incorreta");
                    tentativasRestantes--;

                    Console.Clear();
                }
                else if (!letrasCertas.Contains('_'))
                {
                    Console.WriteLine("Parabéns, você acertou a palavra!");
                    Console.WriteLine("A palavra é: " + palavraSelecionada);
                    break;
                }
            }

            if (tentativasRestantes < 1)
            {
                Console.Clear();
                DesenharForca(0);
                Console.WriteLine("Você perdeu!");
                Console.WriteLine("A palavra era: " + palavraSelecionada);
            }
        }

        static void DesenharForca(int erros)
        {
            switch (erros)
            {
                case 0:
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

                case 1:
                    Console.WriteLine(" -----------");
                    Console.WriteLine(" |/        |");
                    Console.WriteLine(" |         o");
                    Console.WriteLine(" |        /x\\");
                    Console.WriteLine(" |          ");
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
