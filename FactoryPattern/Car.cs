using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car: IVehicle
    {
        public Car() {
        
        }
        public string Name { get; set; } = "SUPER CAR!";
        public bool HasTires { get; set; } = true;
        public int NumTires { get; set; } = 4;

        public void Drive()
        {
            Console.WriteLine($"The car drives far far away from its previous home.");


        }
    }
}
