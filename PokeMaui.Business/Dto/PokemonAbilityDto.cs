using System.Diagnostics;

namespace PokeMaui.Business.Dto
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class PokemonAbilityDto
    {
        public int PokemonId { get; set; }  

        public int AbilityId { get; set; }

        public PokemonDto? Pokemon { get; set; }

        public AbilityDto? Ability { get; set; }

        private string GetDebuggerDisplay()
        {
            return $"Pokemon Id: {PokemonId} - Ability Id: {AbilityId}";
        }
    }
}
