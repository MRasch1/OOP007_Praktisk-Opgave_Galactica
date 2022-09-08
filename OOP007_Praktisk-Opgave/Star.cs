namespace Galactica
{
    internal class Star : SpaceObject
    {
        public StarType type { get; set; }
        public int Temperature { get; set; }

        public List<Planet> PlanetList = new List<Planet>();


    }
}
