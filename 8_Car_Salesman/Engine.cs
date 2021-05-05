using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }


        public Engine(string model, int power, int displacement) :this(model,power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power,string efficiency) :this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency) :this(model,power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }



        //Engine’s displacement and efficiency are optional. 

        public string Model { get; set; }

        public int Power { get; set; }
       
        public int? Displacement { get; set; }

        public string Efficiency { get; set; }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    string dispString = this.Displacement.HasValue ? this.Displacement.ToString() : "n/a";
        //    string effStr = String.IsNullOrEmpty(this.Efficiency) ? "n/a" : this.Efficiency;

        //    sb
        //                   .AppendLine($"{this.Model}:")
        //                   // stringBuilder.AppendLine($"  {Engine.Model}:");
        //    //stringBuilder.AppendLine($"    Power: {Engine.Power}");
        //                   .AppendLine($"    Power: {this.Power}")
        //                   .AppendLine($"    Displacement: {dispString}")
        //                   .AppendLine($"Efficiency: {effStr}");

        //    return base.ToString().TrimEnd();
        //}
    }
}
