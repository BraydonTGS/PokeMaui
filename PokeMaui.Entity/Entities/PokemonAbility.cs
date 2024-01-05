using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace PokeMaui.Entity.Entities
{
    [Table("PokemonAbility")]
    [PrimaryKey(nameof(PokemonId), nameof(AbilityId))]
    public class PokemonAbility
    {
        [Key]
        [Column("PokemonId")]
        [ForeignKey(nameof(Pokemon))]
        public int PokemonId { get; set; }

        [Key]
        [Column("AbilityId")]
        [ForeignKey(nameof(Ability))]
        public int AbilityId { get; set; }

        public Pokemon? Pokemon { get; set; }

        public Ability? Ability { get; set; }
    }
}
