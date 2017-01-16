using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIndexer
{
    public class SolarSystem : StarSystem
    {
        new public string[] planetsName = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };
        public SolarSystem()
        {

        }
        public SolarSystem(string systemName, int planetsNumber)
        {
            this.systemName = systemName;
            this.planetsNumber = planetsNumber;
        }
        public string this[int index]
        { 
            get
            {
                if (index < 0 && index > planetsNumber)
                    throw new IndexOutOfRangeException();
                return planetsName[index];
            }
            set
            {
                planetsName[index] = value;
            }
        }
    }
}
