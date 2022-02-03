namespace SimulareExamenProblema2
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public void Translate(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }
    }
}
