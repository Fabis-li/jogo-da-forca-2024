namespace GestaoEquipamentos.ConsoleApp
{
    public class Equipamentos
    {
        public string Nome;
        public decimal PrecoAquisicao;
        public string NumeroSerie;
        public string DataFabricacao;
        public string Fabricante;
        


        public Equipamentos()
        {
        }

        public Equipamentos(string nome, decimal precoAquisicao, string numeroSerie, string dataFabricacao, string fabricante)
        {
            Nome = nome;
            PrecoAquisicao = precoAquisicao;
            NumeroSerie = numeroSerie;
            DataFabricacao = dataFabricacao;
            Fabricante = fabricante;
            
        }

        public string ListarEquipamentos()
        {
            return $"Número: {NumeroSerie}, Nome: {Nome}, Preço: {PrecoAquisicao}, Fabricante: {Fabricante}, Data Fabricação: {DataFabricacao}";
        }

        public void EditarEquipamento(string nome, decimal precoAquisicao, string numeroSerie, string dataFabricacao, string fabricante)
        {
            this.Nome = nome;
            this.PrecoAquisicao = precoAquisicao;
            this.NumeroSerie = numeroSerie;
            this.DataFabricacao = dataFabricacao;
            this.Fabricante = fabricante;
        }

        public void ExcluirEquipamento()
        {
            this.Nome = "";
            this.PrecoAquisicao = 0;
            this.NumeroSerie = "";
            this.DataFabricacao = "";
            this.Fabricante = "";
        }


    }
}
