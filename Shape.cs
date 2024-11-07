using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderPrototypeApp
{
    public abstract class Shape
    {
        public int x, y;
        public int color;

        public Shape()
        {
            color = 5;
        }

        public Shape(Shape s)
        {
            this.x = s.x;
            this.y = s.y;
            this.color = s.color;
        }

        public abstract Shape Clone();

        public void Init(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

}
