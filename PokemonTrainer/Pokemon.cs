using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string pokemonName, string pokemonElement, int pokemonHealth)
        {
            PokemonName = pokemonName;
            PokemonElement = pokemonElement;
            PokemonHealth = pokemonHealth;
        }

        public string PokemonName { get; set; }

        public string PokemonElement { get; set; }

        public int PokemonHealth { get; set; }

    }
}
