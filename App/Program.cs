using System;
using System.Collections.Generic;
using SpaceSim;


class Astronomy
{
    public static void Main()
    {
        List<SpaceObject> a = new List<SpaceObject>
        {
            new Star("Sun", 0, 0),
            new Planet("Earth", 149600, 365.26),
            new Planet("Mercury", 57910, 87.97),
            new Planet("Venus", 108200, 224.7),
            new Planet("Mars", 227940, 686.98),
            new Planet("Jupiter", 778330, 4332.71),
            new Planet("Saturn", 1429400, 10759.5),
            new Planet("Uranus", 2870990, 30685),
            new Planet("Neptun", 4504300, 60190),
            new Planet("Pluto", 5913520, 90550)
        };

        foreach (var planet in a) {
            if (planet is Planet obj)
            {
                switch (obj.name)
                {
                    //Tar med kun "notable moons"
                    case "Earth":
                        obj.addMoon(new Moon("Moon", 384, 27.32, obj));
                        break;

                    case "Mars":
                        obj.addMoon(new Moon("Phobos", 9, 0.32, obj));
                        obj.addMoon(new Moon("Deimos", 23, 1.26, obj));
                        break;

                    case "Jupiter":
                        obj.addMoon(new Moon("Io", 422, 1.77, obj));
                        obj.addMoon(new Moon("Europa", 671, 3.55, obj));
                        obj.addMoon(new Moon("Ganymede", 1070, 7.15, obj));
                        obj.addMoon(new Moon("Callisto", 1883, 16.69, obj));
                        //og 63 andre måner
                        break;

                    case "Saturn":
                        obj.addMoon(new Moon("Titan", 1222, 15.95, obj));
                        obj.addMoon(new Moon("Rhea", 527, 4.52, obj));
                        obj.addMoon(new Moon("Enceladus", 238, 1.37, obj));
                        break;

                    case "Uranus":
                        obj.addMoon(new Moon("Oberon", 583, 13.46, obj));
                        obj.addMoon(new Moon("Titania", 436, 8.71, obj));
                        obj.addMoon(new Moon("Miranda", 130, 1.41, obj));
                        obj.addMoon(new Moon("Ariel", 191, 2.52, obj));
                        obj.addMoon(new Moon("Umbriel", 266, 4.14, obj));
                        break;

                    case "Neptune":
                        obj.addMoon(new Moon("Triton", 355, -5.88, obj)); //funker det med negativ verdi på period?
                        break;

                    case "Pluto":
                        obj.addMoon(new Moon("Nix", 49, 24.86, obj)); //tar kun med 1
                        break;
                }
            }
        }

        foreach (var s in a)
        {
            s.Draw();
        }

        Console.ReadLine();
    }
}
