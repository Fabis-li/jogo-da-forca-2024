using System.Security.Cryptography.X509Certificates;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CadastrarEquipamento cadastro = new CadastrarEquipamento();
            cadastro.ObterDados();
        }
    }
}
