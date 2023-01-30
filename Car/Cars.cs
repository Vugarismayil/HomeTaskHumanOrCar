using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    internal class Cars:Vehicle
    {
        public int FuelCapacity;
        public int CurrentCapacity;
        public Cars(int fuelCapacity, int currentCapacity)
        {
            FuelCapacity = fuelCapacity;
            CurrentCapacity = currentCapacity;
        }

        public void AddFuel(int Benzin)
        {
            if (CurrentCapacity + Benzin > FuelCapacity)
            {
                Console.WriteLine("Bakın hecmini aşırsınız");
            }
            else
            {
                CurrentCapacity += Benzin;
            }
        }
    }
}
