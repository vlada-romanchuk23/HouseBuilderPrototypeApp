using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilderPrototypeApp
{
    public class Rect_ : Shape
    {
        public int h, w;

        public Rect_() { }

        public Rect_(Rect_ s) : base(s)
        {
            this.h = s.h;
            this.w = s.w;
        }

        public override Shape Clone()
        {
            return new Rect_(this);
        }

        public void Init(int x, int y, int h, int w)
        {
            this.x = x;
            this.y = y;
            this.h = h;
            this.w = w;
        }

        public override string ToString()
        {
            return $"x={x}, y={y}, h={h}, w={w}";
        }
    }

}
