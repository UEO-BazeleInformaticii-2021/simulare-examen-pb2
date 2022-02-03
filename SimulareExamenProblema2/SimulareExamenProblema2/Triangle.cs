using System;

namespace SimulareExamenProblema2
{
    public class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1 ?? new Point(0, 0);
            P2 = p2 ?? new Point(0, 0);
            P3 = p3 ?? new Point(0, 0);
        }

        public Point P1 { get; }

        public Point P2 { get; }

        public Point P3 { get; }

        public override void Translate(int dx, int dy)
        {
            // the translation of triangle means
            // the translation of its points
            P1.Translate(dx, dy);
            P2.Translate(dx, dy);
            P3.Translate(dx, dy);
        }

        public override void Print()
        {
            Console.WriteLine("I am a triangle with the following coordinates:");
            Console.WriteLine($"    - P1: (x = {P1.X}, y={P1.Y})");
            Console.WriteLine($"    - P2: (x = {P2.X}, y={P2.Y})");
            Console.WriteLine($"    - P3: (x = {P3.X}, y={P3.Y})");
        }
    }
}
