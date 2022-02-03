using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulareExamenProblema2
{
    public class Rectangle : Shape
    {
        public Rectangle(Point topLeft, int width, int height)
        {
            // make sure that topLeft is not null before 
            // using it for calculations
            topLeft ??= new Point(0, 0);

            // create all the coordinates of the rectangle
            // based on topLeft and width and height
            // this way we can guarantee that it's indeed
            // a rectangle
            TopLeft = topLeft;
            // on computers coordinates origin is on the top-left
            // corner of the screen
            TopRight = new Point(topLeft.X + width, topLeft.Y);
            BottomRight = new Point(topLeft.X + width, topLeft.Y + height);
            BottomLeft = new Point(topLeft.X, topLeft.Y + height);

            // save also width and height for printing
            Width = width;
            Height = height;
        }

        public Point TopLeft { get; }

        public Point TopRight { get; }

        public Point BottomRight { get; }

        public Point BottomLeft { get; }

        public int Width { get; }

        public int Height { get; }

        public override void Translate(int dx, int dy)
        {
            // the translation of rectangle means
            // the translation of its points
            TopLeft.Translate(dx, dy);
            TopRight.Translate(dx, dy);
            BottomRight.Translate(dx, dy);
            BottomLeft.Translate(dx, dy);
        }

        public override void Print()
        {
            Console.WriteLine("I am a rectangle with the following coordinates:");
            Console.WriteLine($"    - TopLeft: (x = {TopLeft.X}, y={TopLeft.Y})");
            Console.WriteLine($"    - TopRight: (x = {TopRight.X}, y={TopRight.Y})");
            Console.WriteLine($"    - BottomRight: (x = {BottomRight.X}, y={BottomRight.Y})");
            Console.WriteLine($"    - BottomRight: (x = {BottomLeft.X}, y={BottomLeft.Y})");
            Console.WriteLine($"    - Width: {Width}");
            Console.WriteLine($"    - Height: {Height}");

        }
    }
}
