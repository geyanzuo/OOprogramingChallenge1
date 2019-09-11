using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Quadrilateral : Shape
    {
        public int SideLength1;
        public int SideLength2;
        public int SideLength3;
        public int SideLength4;

        public Quadrilateral(int psidelength1, int psidelength2, int psidelength3, int psidelength4, string pcolor) : base(pcolor)
        {

            SideLength1 = psidelength1;
            SideLength2 = psidelength2;
            SideLength3 = psidelength3;
            SideLength4 = psidelength4;
        }

        public int GetPerimeter()
        {
            return SideLength1 + SideLength2 + SideLength3 + SideLength4;
        }
    }
}
