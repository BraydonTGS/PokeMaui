using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PokeMaui.Entity.Entities
{
    [Table("Type")]
    public class Type
    {
        [Key]
        [NotNull]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("TypeName")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonTypes> PokemonTypes { get; set; }
    }
}
