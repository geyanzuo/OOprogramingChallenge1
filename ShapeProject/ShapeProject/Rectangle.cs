using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string pcolor, int psidelength1, int psidelength2) : base(psidelength1, psidelength2, psidelength1, psidelength2, pcolor)
        {
        }

        public int GetArea()
        {
            return SideLength1 * SideLength2;
        }
    }

}
