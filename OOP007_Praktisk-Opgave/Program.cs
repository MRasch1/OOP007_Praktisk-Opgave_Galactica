using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Galactica
{
    public class Program
    {
        static void Main(string[] args)
        {


            Star Sun = new Star();
            Planet Mercury = new Planet();
            Planet Venus = new Planet();
            Planet Earth = new Planet();
            Planet Mars = new Planet();
            Planet Jupiter = new Planet();
            Planet Saturn = new Planet();
            Planet Uranus = new Planet();
            Planet Neptune = new Planet();
            Moon Luna = new Moon();
            Moon Titan = new Moon();
            Moon Phobos = new Moon();
            Moon Europe = new Moon();
            Moon Deimos = new Moon();
            Moon Ganymedes = new Moon();
            Moon Io = new Moon();
            Moon Mimas = new Moon();






            {
                Mercury.Id = 1;
                Mercury.Name = "Mercury";
                Mercury.type = 0;
                Mercury.Diameter_i_M = 300000;
                Mercury.Rotation_i_Timer = 40;
                Mercury.RevolutionPeriod_i_Dage = 300;
                Mercury.ObjectPosition.X = 20;
                Mercury.ObjectPosition.Y = 30;
                Mercury.Distance(Sun.ObjectPosition.X, Sun.ObjectPosition.Y, Mercury.ObjectPosition.X, Mercury.ObjectPosition.Y);

                Venus.Id = 2;
                Venus.Name = "Venus";
                Venus.type = 0;
                Venus.Diameter_i_M = 39000;
                Venus.Rotation_i_Timer = 440;
                Venus.RevolutionPeriod_i_Dage = 600;
                Venus.ObjectPosition.X = 60;
                Venus.ObjectPosition.Y = 40;
                Venus.Distance(Sun.ObjectPosition.X, Sun.ObjectPosition.Y, Venus.ObjectPosition.X, Venus.ObjectPosition.Y);

                Earth.Id = 3;
                Earth.Name = "Earth";
                Earth.type = 0;
                Earth.Diameter_i_M = 30003;
                Earth.Rotation_i_Timer = 24;
                Earth.RevolutionPeriod_i_Dage = 365;
                Earth.ObjectPosition.X = 50;
                Earth.ObjectPosition.Y = 90;
                Earth.Distance(Sun.ObjectPosition.X, Sun.ObjectPosition.Y, Earth.ObjectPosition.X, Earth.ObjectPosition.Y);
                Earth.Moonlist.Add(Luna);


                Mars.Id = 4;
                Mars.Name = "Mars";
                Mars.type = 0;
                Mars.Diameter_i_M = 4002;
                Mars.Rotation_i_Timer = 50;
                Mars.RevolutionPeriod_i_Dage = 2222;
                Mars.ObjectPosition.X = 2424;
                Mars.ObjectPosition.Y = 2545;
                Mars.Distance(Sun.ObjectPosition.X, Sun.ObjectPosition.Y, Mars.ObjectPosition.X, Mars.ObjectPosition.Y);

                Jupiter.Id = 5;
                Jupiter.Name = "Jupiter";
                Jupiter.type = 0;
                Jupiter.Diameter_i_M = 123312;
                Jupiter.Rotation_i_Timer = 2121;
                Jupiter.RevolutionPeriod_i_Dage = 547;
                Jupiter.ObjectPosition.X = 444;
                Jupiter.ObjectPosition.Y = 555;
                Jupiter.Distance(Sun.ObjectPosition.X, Sun.ObjectPosition.Y, Jupiter.ObjectPosition.X, Jupiter.ObjectPosition.Y);
                Jupiter.Moonlist.Add(Mimas);


                Saturn.Id = 6;
                Saturn.Name = "Saturn";
                Saturn.type = 0;
                Saturn.Diameter_i_M = 54467;
                Saturn.Rotation_i_Timer = 5454;
                Saturn.RevolutionPeriod_i_Dage = 234;
                Saturn.ObjectPosition.X = 456;
                Saturn.ObjectPosition.Y = 234;
                Saturn.Distance(Sun.ObjectPosition.X, Sun.ObjectPosition.Y, Saturn.ObjectPosition.X, Saturn.ObjectPosition.Y);
                Saturn.Moonlist.Add(Ganymedes);
                Saturn.Moonlist.Add(Io);



                Uranus.Id = 7;
                Uranus.Name = "Uranus";
                Uranus.type = 0;
                Uranus.Diameter_i_M = 3244;
                Uranus.Rotation_i_Timer = 2354;
                Uranus.RevolutionPeriod_i_Dage = 45;
                Uranus.ObjectPosition.X = 234;
                Uranus.ObjectPosition.Y = 4546;
                Uranus.Distance(Sun.ObjectPosition.X, Sun.ObjectPosition.Y, Uranus.ObjectPosition.X, Uranus.ObjectPosition.Y);
                Uranus.Moonlist.Add(Deimos);


                Neptune.Id = 8;
                Neptune.Name = "Neptune";
                Neptune.type = 0;
                Neptune.Diameter_i_M = 6565;
                Neptune.Rotation_i_Timer = 9898;
                Neptune.RevolutionPeriod_i_Dage = 65765;
                Neptune.ObjectPosition.X = 32487;
                Neptune.ObjectPosition.Y = 09723;
                Neptune.Distance(Sun.ObjectPosition.X, Sun.ObjectPosition.Y, Neptune.ObjectPosition.X, Neptune.ObjectPosition.Y);
                Neptune.Moonlist.Add(Titan);
                Neptune.Moonlist.Add(Phobos);
                Neptune.Moonlist.Add(Europe);

            }

            {
                Luna.Id = 1;
                Luna.Name = "Luna";
                Luna.Orbiting = Earth;
                Luna.ObjectPosition.X = 74;
                Luna.ObjectPosition.Y = 78;
                Luna.Distance(Earth.ObjectPosition.X, Earth.ObjectPosition.Y, Luna.ObjectPosition.X, Luna.ObjectPosition.Y);

                Titan.Id = 2;
                Titan.Name = "Titan";
                Titan.Orbiting = Neptune;
                Titan.ObjectPosition.X = 64;
                Titan.ObjectPosition.Y = 68;
                Titan.Distance(Neptune.ObjectPosition.X, Neptune.ObjectPosition.Y, Titan.ObjectPosition.X, Titan.ObjectPosition.Y);


                Phobos.Id = 3;
                Phobos.Name = "Phobos";
                Phobos.Orbiting = Neptune;
                Phobos.ObjectPosition.X = 54;
                Phobos.ObjectPosition.Y = 58;
                Phobos.Distance(Neptune.ObjectPosition.X, Neptune.ObjectPosition.Y, Phobos.ObjectPosition.X, Phobos.ObjectPosition.Y);


                Europe.Id = 4;
                Europe.Name = "Europe";
                Europe.Orbiting = Neptune;
                Europe.ObjectPosition.X = 44;
                Europe.ObjectPosition.Y = 48;
                Europe.Distance(Neptune.ObjectPosition.X, Neptune.ObjectPosition.Y, Europe.ObjectPosition.X, Europe.ObjectPosition.Y);

                Deimos.Id = 5;
                Deimos.Name = "Deimos";
                Deimos.Orbiting = Uranus;
                Deimos.ObjectPosition.X = 41;
                Deimos.ObjectPosition.Y = 18;
                Deimos.Distance(Uranus.ObjectPosition.X, Uranus.ObjectPosition.Y, Deimos.ObjectPosition.X, Deimos.ObjectPosition.Y);

                Ganymedes.Id = 6;
                Ganymedes.Name = "Ganymedes";
                Ganymedes.Orbiting = Saturn;
                Ganymedes.ObjectPosition.X = 34;
                Ganymedes.ObjectPosition.Y = 28;
                Ganymedes.Distance(Saturn.ObjectPosition.X, Saturn.ObjectPosition.Y, Ganymedes.ObjectPosition.X, Ganymedes.ObjectPosition.Y);

                Io.Id = 7;
                Io.Name = "Io";
                Io.Orbiting = Saturn;
                Io.ObjectPosition.X = 44;
                Io.ObjectPosition.Y = 98;
                Io.Distance(Saturn.ObjectPosition.X, Saturn.ObjectPosition.Y, Io.ObjectPosition.X, Io.ObjectPosition.Y);

                Mimas.Id = 8;
                Mimas.Name = "Mimas";
                Mimas.Orbiting = Jupiter;
                Mimas.ObjectPosition.X = 8;
                Mimas.ObjectPosition.Y = 12;
                Mimas.Distance(Jupiter.ObjectPosition.X, Jupiter.ObjectPosition.Y, Mimas.ObjectPosition.X, Mimas.ObjectPosition.Y);
            }

            Sun.Id = 1;
            Sun.Name = "Sun";
            Sun.type = 0;
            Sun.Temperature = 200000;
            Sun.ObjectPosition.X = 0;
            Sun.ObjectPosition.Y = 0;
            Sun.PlanetList.Add(Mercury);
            Sun.PlanetList.Add(Venus);
            Sun.PlanetList.Add(Earth);
            Sun.PlanetList.Add(Mars);
            Sun.PlanetList.Add(Jupiter);
            Sun.PlanetList.Add(Saturn);
            Sun.PlanetList.Add(Uranus);
            Sun.PlanetList.Add(Neptune);

            
            foreach (var planet in Sun.PlanetList)
            {
                int counter = 0;
                Console.WriteLine("Planet name: " + planet.Name + ". " + "Planet type: " + planet.type + ". " + "Planet distance to sun: " + planet.distance + ".");
                foreach (var moon in planet.Moonlist)
                {
                    counter++;
                    Console.WriteLine(counter+" "+"Moon name: " + moon.Name + ". " + "Moon distance to planet: " + moon.moonDistance + ".");
                }
            }

            

        }
    }
}