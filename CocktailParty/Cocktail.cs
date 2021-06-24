using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredient;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            ingredient = new List<Ingredient>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        // public int 

        public int CurrentAlcoholLevel => 123456;

        public void Add(Ingredient ingredient)
        {

            if (!this.ingredient.Contains(ingredient) &&ingredient.Quantity>0 && ingredient.Alcohol>0)
            {
                this.ingredient.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            //Car car = data.FirstOrDefault(p => p.Manufacturer == manifacturer && p.Model == model);
            Ingredient ingredient = this.ingredient.FirstOrDefault(c => c.Name == name);
            if (ingredient==null)
            {
                return false;
            }

            this.ingredient.Remove(ingredient);
            return true;
        }

        public Ingredient FindIngredient(string name)
        {
            Ingredient ingredient = this.ingredient.FirstOrDefault(n => n.Name == name);
            if (ingredient==null)
            {
                return null;
            }

            return ingredient;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            Ingredient ingredient = this.ingredient.OrderByDescending(a => a.Alcohol).FirstOrDefault();
            return ingredient;

        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");

            foreach (var item in this.ingredient)
            {
                result.AppendLine($"{item}");
            }

            return result.ToString();
        }


    }
}