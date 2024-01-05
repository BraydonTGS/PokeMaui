namespace PokeMaui.Entity.Entities
{
    public class Ability
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonAbility> PokemonAbility { get; set; }
    }
}
