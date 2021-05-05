using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;

        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTravelled)
        {
            double fuelAmountNeeded = distanceTravelled * this.FuelConsumptionPerKilometer;

            if (fuelAmountNeeded>this.FuelAmount)
            {
                //Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
            else
            {
                this.TravelledDistance += distanceTravelled;
                this.FuelAmount -= fuelAmountNeeded;
                return true;
            }
            
        }

    }
}
