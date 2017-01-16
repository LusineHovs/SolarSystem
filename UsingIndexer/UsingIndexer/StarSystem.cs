using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIndexer
{
    public abstract class StarSystem
    {
        protected string systemName { get; set; }
        protected int planetsNumber;
        protected string[] planetsName { get; set; }
    }
}
