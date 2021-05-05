using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string trainerName)
        {
            TrainerName = trainerName;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }

        //propfull 2XTab 
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


        public string TrainerName { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; } 

    }
}
