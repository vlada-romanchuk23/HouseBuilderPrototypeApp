﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderPrototypeApp
{
    public interface IHouseBuilder
    {
        void BuildWalls();
        void BuildRoof();
        void BuildWindows();
        House GetHouse();
    }

}
