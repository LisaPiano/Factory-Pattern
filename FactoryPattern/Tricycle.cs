using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Tricycle: IVehicle
    {
        public Tricycle()
        { 
        }
        public void Drive() 
        {
            Console.WriteLine("The small tricycle drives very slowly.");
        }

        public string Name { get; set; } = "Trike";
        public bool HasTires { get; set; }
        public int NumTires { get; set; } = 3;

    }
}
