using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel => Ingredients.Sum(i => i.Alcohol);

        public ICollection<Ingredient> Ingredients { get; set; }

        public void Add(Ingredient ingredient)
        {
            if (!Ingredients.Any(i => i.Name == ingredient.Name)
                && Ingredients.Count < Capacity
                && (CurrentAlcoholLevel + ingredient.Alcohol <= MaxAlcoholLevel))
            {
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            var ingredient = FindIngredient(name);
            if (ingredient == null)
            {
                return false;
            }

            Ingredients.Remove(ingredient);
            return true;
        }

        public Ingredient FindIngredient(string name)
        {
            return Ingredients.Where(i => i.Name == name).FirstOrDefault();
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return Ingredients.OrderByDescending(i => i.Alcohol).FirstOrDefault();
        }

        public string Report()
        {
            var result = new StringBuilder();

            result.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            result.AppendJoin(Environment.NewLine, Ingredients);

            return result.ToString();
        }
    }
}