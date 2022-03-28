using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ASE_Basics
{
    public class Car1:ICar1
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Model { get; set; } 
        public int NoOfSeats { get; set; }
        public int NoOfDoors { get; set; }
        public int Kilometers { get; set; }
        public CapacityEnum Capacity { get; set; }
        public string Color { get; set; }
        public int GetNoOfSeats(string model)
        {
            throw new NotImplementedException();
        }
        public void Run()
        {
            if((int)Capacity<600)
            {
                throw new Exception("Impossible to start the car.");
            }
            else { Console.WriteLine("Car started:" + Brand + " " + Model); }
        }
    }
}
