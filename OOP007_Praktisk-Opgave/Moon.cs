namespace Galactica
{
    internal class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        public double moonDistance;
       internal override double Distance(int x1, int y1, int x2, int y2)
        {
            moonDistance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return moonDistance;
        }
    }
}
