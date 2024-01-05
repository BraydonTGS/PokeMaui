﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeMaui.Entity.Entities
{

    [Table("PokemonMoves")]
    [PrimaryKey(nameof(PokemonId), nameof(MoveId))]
    public class PokemonMoves
    {
        [Key]
        [Column("PokemonId")]
        [ForeignKey(nameof(Pokemon))]
        public Guid PokemonId { get; set; }

        [Key]
        [Column("MoveId")]
        [ForeignKey(nameof(Move))]
        public Guid MoveId { get; set; }

        public Pokemon? Pokemon { get; set; }

        public Move? Move { get; set; }
    }
}
