using System;
using System.Collections.Generic;
using System.Text;

namespace Lines
{
    class HorizontalLine
    {
        public List<Point> pointList = new List<Point>();


        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {

            for (int i = xLeft; i <= xRight; i++)
            {
                Point newPoint = new Point(i, y, symbol);
                pointList.Add(newPoint);

            }
        }

        public void DrawHorizontalLine()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}
