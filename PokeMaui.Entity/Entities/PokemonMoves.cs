namespace PokeMaui.Entity.Entities
{
    public class PokemonMoves
    {
        public int PokemonId { get; set; }

        public int MoveId { get; set; }

        public Pokemon? Pokemon { get; set; }

        public Move? Move { get; set; }
    }
}
