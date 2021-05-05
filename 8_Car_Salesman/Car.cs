using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            
        }

        public Car(string model, Engine engine, double weight)
            :this(model, engine)
        {

            this.Weight = weight;
            
        }

        public Car(string model, Engine engine, string color)
            :this(model,engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, double weight, string color)
            :this(model,engine)
        {
            
            this.Weight = weight;
            this.Color = color;
        }

        //A Car’s weight and color are optional

        public string Model { get; set; }
        public Engine Engine { get; set; }
        
        public double? Weight { get; set; }
        public string  Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string weightStr = this.Weight.HasValue ? this.Weight.ToString() : "n/a";
            string colorStr = String.IsNullOrEmpty(this.Color) ? "n/a" : this.Color;
            string dispString = Engine.Displacement.HasValue ? Engine.Displacement.ToString() : "n/a";
            string effStr = String.IsNullOrEmpty(Engine.Efficiency) ? "n/a" : Engine.Efficiency;

            sb
                .AppendLine($"{Model}:")
                .AppendLine($"  {Engine.Model}:")
                .AppendLine($"    Power: {Engine.Power}")
                .AppendLine($"    Displacement: {dispString}")
                .AppendLine($"    Efficiency: {effStr}")
                .AppendLine($"  Weight: {weightStr}")
                .Append($"  Color: {colorStr}");
            return sb.ToString().TrimEnd();


            ////stringBuilder.AppendLine($"{Model}:");
            ////stringBuilder.AppendLine($"  {Engine.Model}:");
            ////stringBuilder.AppendLine($"    Power: {Engine.Power}");
            ////stringBuilder.AppendLine($"    Displacement: {Engine.Displacement}");
            ////stringBuilder.AppendLine($"    Efficiency: {Engine.Efficiency}");
            ////stringBuilder.AppendLine($"  Weight: {Weight}");
            ////stringBuilder.Append($"  Color: {Color}");
        }
    }
}
