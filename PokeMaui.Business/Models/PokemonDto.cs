using System.Diagnostics;

namespace PokeMaui.Business.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class PokemonDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Order { get; set; }

        public int Weight { get; set; }

        public int BaseExperience { get; set; }

        public int Height { get; set; }

        public SpriteDto Sprite { get; set; }

        public IEnumerable<PokemonTypesDto> PokemonTypes { get; set; }

        public IEnumerable<PokemonAbilityDto> PokemonAbility { get; set; }

        public IEnumerable<FormDto> Forms { get; set; }

        public IEnumerable<PokemonMovesDto> PokemonMoves { get; set; }

        public PokemonDto() { }

        private string GetDebuggerDisplay()
        {
            return $"Name: {Name} - Id: {Id}";
        }
    }
}
