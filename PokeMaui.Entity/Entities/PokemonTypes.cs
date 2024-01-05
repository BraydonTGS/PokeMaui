namespace PokeMaui.Entity.Entities
{
    public class PokemonTypes
    {
        public int PokemonId { get; set; }

        public int TypeId { get; set; }

        public Pokemon? Pokemon { get; set; }

        public Type? Type { get; set; }
    }
}
