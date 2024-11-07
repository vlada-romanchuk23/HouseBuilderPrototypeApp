using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderPrototypeApp
{
    public class LuxuryHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildWalls()
        {
            _house.Walls = "Luxury walls";
        }

        public void BuildRoof()
        {
            _house.Roof = "Luxury roof";
        }

        public void BuildWindows()
        {
            _house.Windows = "Large windows";
        }

        public House GetHouse()
        {
            return _house;
        }
    }

}
