using System.Diagnostics;

namespace PokeMaui.Business.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class PokemonTypesDto
    {
        public Guid PokemonId { get; set; }

        public Guid TypeId { get; set; }

        public PokemonDto? Pokemon { get; set; }

        public TypeDto? Type { get; set; }

        private string GetDebuggerDisplay()
        {
            return $"Pokemon Id: {PokemonId} - Type Id: {TypeId}";
        }
    }
}