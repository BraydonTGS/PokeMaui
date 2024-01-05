using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PokeMaui.Entity.Entities
{
    [Table("Ability")]
    public class Ability
    {
        [Key]
        [NotNull]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("AbilityName")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonAbility> PokemonAbility { get; set; }
    }
}
