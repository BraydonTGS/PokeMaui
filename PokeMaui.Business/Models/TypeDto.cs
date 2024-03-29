﻿using System.Diagnostics;

namespace PokeMaui.Business.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class TypeDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<PokemonTypesDto> PokemonTypes { get; set; }

        public TypeDto() { }

        private string GetDebuggerDisplay()
        {
            return $"Type: {Name} - Id: {Id}";
        }
    }
}