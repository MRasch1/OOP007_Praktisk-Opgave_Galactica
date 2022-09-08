using System.Security.Cryptography.X509Certificates;

namespace Galactica
{
    internal class SpaceObject
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public Position ObjectPosition { get; set; } = new Position();

        public class Position
        {
            public int X { get; set; }

            public int Y { get; set; }

            public override string ToString()
            {
                return "X & Y position: " + (X, Y);
            }
        }
        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }

        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }


    }
}
