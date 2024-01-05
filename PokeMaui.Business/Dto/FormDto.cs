using System.Diagnostics;

namespace PokeMaui.Business.Dto
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class FormDto
    {
        public int Id { get; set; } 

        public string Name { get; set; } = string.Empty;

        public int PokemonId { get; set; }

        public PokemonDto? Pokemon { get; set; }

        private string GetDebuggerDisplay()
        {
            return $"Form: {Name} - Id: {Id}";
        }
    }
}