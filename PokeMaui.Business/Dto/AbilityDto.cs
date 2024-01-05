using System.Diagnostics;

namespace PokeMaui.Business.Dto
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class AbilityDto
    {
        public int Id { get; set; } 

        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonAbilityDto> PokemonAbility{ get; set; }

        public AbilityDto() {}

        private string GetDebuggerDisplay()
        {
            return $"Ability: {Name} - Id: {Id}";
        }
    }
}