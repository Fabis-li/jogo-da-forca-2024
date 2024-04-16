namespace GestaoEquipamentos.ConsoleApp
{
    public class CadastrarEquipamento
    {
        Equipamentos equipamento = new Equipamentos();
        public string[] ArmazenarDadosEquipamento;

        public void ObterDados()
        {
            Console.WriteLine("Cadastro de Equipamentos\n");
            Console.WriteLine("Registrando um novo Equipamento\n");
            Console.Write("Digite o nome do equipamento: ");
            equipamento.Nome = Console.ReadLine();

            Console.Write("\nDigite o preço do equipamento: ");
            equipamento.PrecoAquisicao = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nDigite o número de serie do equipamento: ");
            equipamento.NumeroSerie = Console.ReadLine();
            Console.Write("\nDigite a data de fabricação: ");
            equipamento.DataFabricacao = Console.ReadLine();

        }

    }
}
