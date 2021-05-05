using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        //Class Car holds an information about model, engine, cargo and a collection of exactly 4 tires. 
        //Create a constructor that receives all of the information about the Car and creates 
        //and initializes its inner components (engine, cargo and tires).
        //"{model} {int engineSpeed} {int enginePower} {int cargoWeight} {cargoType} {double tire1Pressure} 
        //{int tire1Age}  {double tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
        //ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4

        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }
    }
}
