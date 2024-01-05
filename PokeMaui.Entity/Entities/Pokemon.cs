using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PokeMaui.Entity.Entities
{
    [Table("Pokemon")]
    public class Pokemon
    {
        [Key]
        [NotNull]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("PokemonName")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column("Order")]
        public int Order { get; set; }

        [Column("Weight")]
        public int Weight { get; set; }

        [Column("BaseExperience")]
        public int BaseExperience { get; set; }

        [Column("Height")]
        public int Height { get; set; }

        public Sprite Sprite { get; set; }

        public IEnumerable<PokemonTypes> PokemonTypes { get; set; }

        public IEnumerable<PokemonAbility> PokemonAbility { get; set; }

        public IEnumerable<Form> Forms { get; set; }

        public IEnumerable<PokemonMoves> PokemonMoves { get; set; }
    }
}
