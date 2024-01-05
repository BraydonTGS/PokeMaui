namespace PokeMaui.Entity.Entities
{
    public class Move
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonMoves> PokemonMoves { get; set; }
    }
}
