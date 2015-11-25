namespace ControleGames.Models
{
    /// <summary>
    /// Classe que modela um Game
    /// </summary>
    public class Game
	{
        public int GameId { get; set; }
        public string Nome { get; set; }
        public int AnoLancamento { get; set; }
        public string Distribuidora { get; set; }
        public Categoria Categoria { get; set; }
        public Plataforma Plataforma { get; set; }
        public decimal ValorVenda { get; set; }
    }
}