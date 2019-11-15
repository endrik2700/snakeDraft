using System;

namespace Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80,25);
            HorizontalLine topline = new HorizontalLine(0, 78, 0, '*');
            topline.DrawHorizontalLine();
            HorizontalLine bottomline = new HorizontalLine(0, 78, 24, '*');
            topline.DrawHorizontalLine();
            VerticaLLine leftLine = new VerticaLLine(0,24,0,'*');
            leftLine.DrawwVertialLine();
            VerticaLLine rightLine = new VerticaLLine(0,24,78,'*');
            rightLine.DrawwVertialLine();

            Console.ReadLine();
        }
    }
}
