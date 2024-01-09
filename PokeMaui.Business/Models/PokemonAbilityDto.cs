using System.Diagnostics;

namespace PokeMaui.Business.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class PokemonAbilityDto
    {
        public Guid PokemonId { get; set; }  

        public Guid AbilityId { get; set; }

        public PokemonDto? Pokemon { get; set; }

        public AbilityDto? Ability { get; set; }

        private string GetDebuggerDisplay()
        {
            return $"Pokemon Id: {PokemonId} - Ability Id: {AbilityId}";
        }
    }
}
