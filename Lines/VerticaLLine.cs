using System;
using System.Collections.Generic;
using System.Text;

namespace Lines
{
    class VerticaLLine
    {
        
        
            public List<Point> pointList = new List<Point>();


            public VerticaLLine (int yBottom, int yTop, int x,  char symbol)
            {

                for (int i = yTop; i <= yBottom; i++)
                {
                    Point newPoint = new Point(x, i, symbol);
                    pointList.Add(newPoint);

                }
            }

            public void DrawwVertialLine()
            {
                foreach (Point point in pointList)
                {
                    point.Draw();
                }
            }
        
    }
}
