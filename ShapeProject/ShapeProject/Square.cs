using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Square : Quadrilateral
    {
        public Square(string pcolor, int psidelength1) : base(psidelength1, psidelength1, psidelength1, psidelength1, pcolor)
        {
        }

        public int GetArea()
        {
            return SideLength1 * SideLength1;
        }
    }
}
