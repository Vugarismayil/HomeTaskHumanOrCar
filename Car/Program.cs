using System;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars(250, 200)
            {
                Brand = "Subaru",
                Model = "WRX STI 500",
                Milage = 150
            };
            Console.WriteLine(car.CurrentCapacity);
        }
    }
}
