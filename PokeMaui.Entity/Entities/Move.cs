using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PokeMaui.Entity.Entities
{
    [Table("Move")]
    public class Move
    {
        [Key]
        [NotNull]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("MoveName")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonMoves> PokemonMoves { get; set; }
    }
}
