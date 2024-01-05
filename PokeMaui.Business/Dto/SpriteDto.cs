using System.Diagnostics;

namespace PokeMaui.Business.Dto
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class SpriteDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public object Image { get; set; } = string.Empty;

        public int PokemonId { get; set; }

        public PokemonDto? Pokemon { get; set; }

        public SpriteDto() { }

        private string GetDebuggerDisplay()
        {
            return $"Sprite: {Name} - Id: {Id}";
        }
    }
}