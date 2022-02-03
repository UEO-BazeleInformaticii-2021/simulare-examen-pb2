using System;

namespace SimulareExamenProblema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(
                p1: new Point(10, 10),
                p2: new Point(30, 30),
                p3: new Point(10, 30));

            Rectangle r = new Rectangle(
                topLeft: new Point(50, 50),
                width: 100,
                height: 50);

            // print to see coordinates before applying translation
            t.Print();
            r.Print();

            // apply translation on both triangle and rectangle
            GeometryUtils.Translate(20, 20, t, r);

            // print again to see coordinates after applying translation
            t.Print();
            r.Print();
        }
    }
}
