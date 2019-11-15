using System;

namespace SnakeDraft
{
    class Program
    {   class Point {

            public int x;
            public int y;
            public char symbol;

            public  Point(int _x, int _y,char _symbol)
            {
                x = _x;
                y = _y;
                symbol = _symbol;

            }

            public void Draw() {

                Console.SetCursorPosition(x, y);
                Console.WriteLine(symbol);


            }

        }
        
        

        static void Main(string[] args)
        {
            int x1 = 0;
            int y1 = 0;
            char symbol = '*';

            Console.ForegroundColor = ConsoleColor.Cyan;
            Point p1 = new Point(10, 10, '*');
            p1.Draw();
            Point p2 = new  Point(x1, y1, symbol);
            p2.Draw();

        }

       
    }
    }

