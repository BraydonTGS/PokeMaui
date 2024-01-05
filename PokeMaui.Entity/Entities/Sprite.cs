using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PokeMaui.Entity.Entities
{
    [Table("Sprite")]
    public class Sprite
    {
        [Key]
        [NotNull]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("Name")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column("Description")]
        public string Description { get; set; } = string.Empty;

        [Column("Image")]
        public string Image { get; set; } = string.Empty;

        [Column("PokemonId")]
        [ForeignKey(nameof(Pokemon))]
        public Guid PokemonId { get; set; }

        public Pokemon? Pokemon { get; set; }
    }
}
