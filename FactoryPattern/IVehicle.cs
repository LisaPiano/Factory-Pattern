using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle
    {
        public void Drive();
        string Name { get; set; }

        bool HasTires { get; set; }

        int NumTires { get; set; }
    }
}
