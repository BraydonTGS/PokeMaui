using System.Diagnostics;

namespace PokeMaui.Business.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class SpriteDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public object Image { get; set; } = string.Empty;

        public Guid PokemonId { get; set; }

        public PokemonDto? Pokemon { get; set; }

        public SpriteDto() { }

        private string GetDebuggerDisplay()
        {
            return $"Sprite: {Name} - Id: {Id}";
        }
    }
}