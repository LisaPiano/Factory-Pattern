using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle: IVehicle
    {

        public Motorcycle()
        
        {
        
        }
        public void Drive()
        {
            Console.WriteLine("The motorcycle speedily drives down the freeway!");
        }

        public string Name { get; set; } = "Awesomemobile!";
        public bool HasTires { get; set; }
        public int NumTires { get; set; } = 2;
    }
}
