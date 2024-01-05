namespace PokeMaui.Entity.Entities
{
    public class PokemonAbility
    {
        public int PokemonId { get; set; }

        public int AbilityId { get; set; }

        public Pokemon? Pokemon { get; set; }

        public Ability? Ability { get; set; }
    }
}
