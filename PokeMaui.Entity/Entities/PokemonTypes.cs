using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeMaui.Entity.Entities
{
    [Table("PokemonTypes")]
    [PrimaryKey(nameof(PokemonId), nameof(TypeId))]
    public class PokemonTypes
    {
        [Key]
        [Column("PokemonId")]
        [ForeignKey(nameof(Pokemon))]
        public int PokemonId { get; set; }

        [Key]
        [Column("TypeId")]
        [ForeignKey(nameof(Type))]
        public int TypeId { get; set; }

        public Pokemon? Pokemon { get; set; }

        public Type? Type { get; set; }
    }
}
