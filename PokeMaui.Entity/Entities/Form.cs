﻿namespace PokeMaui.Entity.Entities
{
    public class Form
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int PokemonId { get; set; }

        public Pokemon? Pokemon { get; set; }
    }
}
