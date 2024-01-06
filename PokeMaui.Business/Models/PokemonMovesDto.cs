using System.Diagnostics;

namespace PokeMaui.Business.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class PokemonMovesDto
    {
        public int PokemonId { get; set; }

        public int MoveId { get; set; }

        public PokemonDto? Pokemon { get; set; }

        public MoveDto? Move { get; set; }

        private string GetDebuggerDisplay()
        {
            return $"Pokemon Id: {PokemonId} - Move Id: {MoveId}";
        }
    }
}