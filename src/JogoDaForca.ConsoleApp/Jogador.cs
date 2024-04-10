namespace JogoDaForca.ConsoleApp
{
    public class Jogador
    {
        private int tentativasRestantes = 5;
        private char[] letrasTentadas = new char[26];

        public int TentativasRestantes => tentativasRestantes;

        public bool Chute(char letra)
        {
            if (!char.IsLetter(letra) || letrasTentadas.Contains(letra))               
                return false;          

            letrasTentadas[25 - (int)('Z' - letra)] = letra;
            return true;
        }

        public void DecrementarTentativas()
        {
            tentativasRestantes--;
        }

        public string LetrasTentadas()
        {
            return new string(letrasTentadas.Where(c => c != '\0').ToArray());
        }
        
    }
}
