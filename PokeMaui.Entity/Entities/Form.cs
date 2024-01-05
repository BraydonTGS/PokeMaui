using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PokeMaui.Entity.Entities
{
    [Table("Form")]
    public class Form
    {
        [Key]
        [NotNull]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("FormName")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column("PokemonId")]
        [ForeignKey(nameof(Pokemon))]
        public int PokemonId { get; set; }

        public Pokemon? Pokemon { get; set; }
    }
}
