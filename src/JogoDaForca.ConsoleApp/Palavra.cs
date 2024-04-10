namespace JogoDaForca.ConsoleApp
{
    internal class Palavra
    {
        private string palavra;
        private char[] letrasCertas;
        Jogador jogador = new Jogador();

        public Palavra (string palavra)
        {               
            this.palavra = palavra;
            letrasCertas = new char[palavra.Length];
            for (int i = 0; i < letrasCertas.Length; i++)
            {
                letrasCertas[i] = '_';
            }            
        }

        public bool RevelarLetra(char letra)
        {
            bool acertou = false;
            for (int i = 0;i < letrasCertas.Length;i++)
            {
                if (palavra[i] == letra)
                {
                    letrasCertas[i] = letra;
                    acertou = true;
                }                
            }
            return acertou;
        }

        public bool LetrasReveladas()
        {
            return !letrasCertas.Contains('_');
        }

        public string PalavraOculta()
        {
            return new string(letrasCertas);
        }
    }
}
