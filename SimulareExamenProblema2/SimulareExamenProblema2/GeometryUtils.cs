namespace SimulareExamenProblema2
{
    public static class GeometryUtils
    {
        public static void Translate(int dx, int dy, params Shape[] shapes)
        {
            foreach (Shape s in shapes ?? new Shape[0])
            {
                s.Translate(dx, dy);
            }
        }
    }
}
