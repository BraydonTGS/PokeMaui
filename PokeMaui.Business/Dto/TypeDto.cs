using System.Diagnostics;

namespace PokeMaui.Business.Dto
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class TypeDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonTypesDto> PokemonTypes { get; set; }

        public TypeDto() { }

        private string GetDebuggerDisplay()
        {
            return $"Type: {Name} - Id: {Id}";
        }
    }
}