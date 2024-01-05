namespace PokeMaui.Entity.Entities
{
    public class Type
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonTypes> PokemonTypes { get; set; }
    }
}
