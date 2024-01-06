using System.Diagnostics;

namespace PokeMaui.Business.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class MoveDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonMovesDto> PokemonMoves { get; set; }

        public MoveDto() { }

        private string GetDebuggerDisplay()
        {
            return $"Move: {Name} - Id: {Id}";
        }
    }
}