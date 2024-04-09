using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    public class JogoDaForca
    {
        string[] palavrasSecretas = {
            "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARAÇA", "BACABA", "BACURI", "BANANA", "CAJA",
            "CAJU", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇA",
            "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI",
            "TANGERINA", "UMBU", "UVA", "UVAIA"
        };

        public string PalavraAleatoria()
        {
            Random random = new Random();
            string palavraSelecionada = palavrasSecretas[random.Next(0, palavrasSecretas.Length)];
            return palavraSelecionada;
        }

        public char[] QtdeLetras(string palavraSelecionada)
        {
            char[] letrasCertas = new char[palavraSelecionada.Length];
            for (int i = 0; i < letrasCertas.Length; i++)
            {
                letrasCertas[i] = '_';
            }

            return letrasCertas;
        }

        private int tentativasRestantes = 5;
        private char[] letrasTentadas = new char[26];

        public void ExibirMenu(char[] letrasCertas, int tentativasRestantes, char[] letrasTentadas)
        {
            Console.WriteLine("Palavra" + string.Join(" ", letrasCertas));
            Console.WriteLine("Tentativas restantes: " + tentativasRestantes);
            Console.WriteLine("Letras tentadas: " + string.Join(" ", letrasTentadas));
        }
        public char ObterLetra()
        {
            Console.WriteLine("Digite uma letra:");
            char letra = Console.ReadLine().ToUpper()[0];//
            Console.WriteLine();
            return letra;
        }

        public int VerificarEhLetra(int tentativa, char letra)
        {
            if (!char.IsLetter(letra))
            {
                Console.WriteLine("Digite apenas letras");
                tentativa--;
                continue;
            }

            return tentativa;
        }

        public int VerificaDuplicidadeLetra(int tentativa, char letra)
        {
            if (Array.IndexOf(letrasTentadas, letra) != -1)
            {
                Console.WriteLine("Você já tentou essa letra");
                tentativa--;
                continue;
            }

            return tentativa;
        }

        public void ObterPosicaoLetraTentada(char letra )
        {
            letrasTentadas[25 - (int)('Z' - letra)] = letra; // 25 - (int)('Z' - letra) é a posição da letra no array letrasTentadas
        }

        public bool VerificarAcertouLetra(string palavraSelecionada, char letra, char[] letrasCertas)
        {
            
            bool acertou = false;
            for (int i = 0; i < palavraSelecionada.Length; i++)
            {
                if (palavraSelecionada[i] == letra)
                {
                    letrasCertas[i] = letra;
                    acertou = true;
                }
            }

            return acertou;
        }
        public void VerificarAcertouPalavra(bool acertou, char[] letrasCertas, string palavraSelecionada)
        {
            if (!acertou)
            {
                Console.WriteLine("Letra Incorreta");
            }
            else if (!letrasCertas.Contains('_'))
            {
                Console.WriteLine("Parabéns, você acertou a palavra!");
                Console.WriteLine("A palavra é: " + palavraSelecionada);
                break;
            }
        }

        private static void MensagemDerrota(char[] letrasCertas, string palavraSelecionada)
        {
            if (letrasCertas.Contains('_'))
            {
                Console.WriteLine("Você perdeu!");
                Console.WriteLine("A palavra era: " + palavraSelecionada);
            }
        }



    }
}
