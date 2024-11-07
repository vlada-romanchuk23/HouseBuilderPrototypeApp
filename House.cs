using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderPrototypeApp
{
    public class House
    {
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Windows { get; set; }

        public House Clone()
        {
            return (House)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"House with {Walls}, {Roof}, and {Windows}.";
        }
    }

}
