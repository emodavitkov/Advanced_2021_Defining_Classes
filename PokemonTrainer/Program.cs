using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Trainer currentTrainer = null;
            Pokemon pokemon = null;
            
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            List<Pokemon> pokemons = new List<Pokemon>();

            // better with disctionary  not with list -->List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line== "Tournament")
                {
                    break;
                }

                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                //     Peter        Charizard        Fire            100
                //     George       Squirtle         Water            38

                string[] input = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int    pokemonHealth = int.Parse(input[3]);

                pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
               

                if (!trainers.ContainsKey(trainerName))
                {
                    currentTrainer = new Trainer(trainerName);
                    trainers.Add(trainerName, currentTrainer);
                }

                currentTrainer = trainers[trainerName];
                //currentTrainer = trainers.FirstOrDefault(x => x.Key == trainerName).Value;
                
                currentTrainer.Pokemons.Add(pokemon);

               

            }

            while (true)
            {
                string element = Console.ReadLine();

                if (element=="End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(p => p.PokemonElement==element))
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        //trainer.Value.Pokemons.ForEach(p => p.PokemonHealth -= 10);

                        foreach (var item in trainer.Value.Pokemons)
                        {
                            item.PokemonHealth -= 10;
                        }
                        trainer.Value.Pokemons.RemoveAll(x => x.PokemonHealth <= 0);
                    }
                }

            }

            var result = trainers.OrderByDescending(x => x.Value.NumberOfBadges)
                .ToDictionary(k => k.Key, v=> v.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} {item.Value.NumberOfBadges} {item.Value.Pokemons.Count}");
            }

           

        }
    }
}
