﻿using System;

namespace SnakeDraft
{
    partial class Program
    {
        class Point
        {

            public int x;
            public int y;
            public char symbol;

            public Point(int _x, int _y, char _symbol)
            {
                x = _x;
                y = _y;
                symbol = _symbol;

            }

            public void Draw()
            {

                Console.SetCursorPosition(x, y);
                Console.WriteLine(symbol);


            }

        }


    }
}
