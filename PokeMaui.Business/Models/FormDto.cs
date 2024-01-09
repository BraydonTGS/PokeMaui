using System.Diagnostics;

namespace PokeMaui.Business.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class FormDto
    {
        public Guid Id { get; set; } 

        public string Name { get; set; } = string.Empty;

        public Guid PokemonId { get; set; }

        public PokemonDto? Pokemon { get; set; }

        private string GetDebuggerDisplay()
        {
            return $"Form: {Name} - Id: {Id}";
        }
    }
}