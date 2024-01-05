namespace PokeMaui.Entity.Entities
{
    public class Sprite
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public object Image { get; set; } = string.Empty;

        public int PokemonId { get; set; }

        public Pokemon? Pokemon { get; set; }
    }
}
