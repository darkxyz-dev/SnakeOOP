using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class VerticalLine : Figure
    {
        


        public VerticalLine(int yUP, int yDown, int x, char symb)
        {
            pointList = new List<Point>();
            for(int i = yUP; i <= yDown; i++)
            {
                Point p = new Point(x, i, symb);
                pointList.Add(p);
            }
        }

        
    }

}
