namespace Galactica
{
    internal class Planet : SpaceObject
    {
        public PlanetType type { get; set; }

        public int Diameter_i_M { get; set; }

        public int Rotation_i_Timer { get; set; }

        public int RevolutionPeriod_i_Dage { get; set; }

        public List<Moon> Moonlist = new List<Moon>();

        public double distance;

        internal virtual double Distance(int x1, int y1, int x2, int y2)
        {
            //√((x_2 - x_1)²+(y_2 - y_1)²)

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;

        }

    }
}
