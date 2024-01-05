namespace PokeMaui.Entity.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Order { get; set; }

        public int Weight { get; set; }

        public int BaseExperience { get; set; }

        public int Height { get; set; }

        public Sprite Sprite { get; set; }

        public IEnumerable<PokemonTypes> PokemonTypes { get; set; }

        public IEnumerable<PokemonAbility> PokemonAbility { get; set; }

        public IEnumerable<Form> Forms { get; set; }

        public IEnumerable<PokemonMoves> PokemonMoves { get; set; }
    }
}
