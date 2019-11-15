using System;

namespace SnakeDraft
{
    class Program
    {



        static void Main(string[] args)
        {/*
            for (int i=0; i<=10; i++) {

                char a = '*';
                int xcord = i;
                int ycord = 0;
                Point newPoint = new Point(xcord,ycord,a);
                newPoint.Draw();
             for (int j=0; j<=10;j++) {
                    char b = '*';
                    int xcord1 = 0;
                    int ycord2 = j;
                    Point newPoint2 = new Point(xcord1, ycord2, b);
                    newPoint2.Draw();

                }
            
            }*/
            HorizontalLine hrLine = new HorizontalLine(5, 10, 10, '*');
            hrLine.DrawHorizontalLine;
            Console.ReadLine();
        }


    }
}
