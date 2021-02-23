using System;
using System.Collections.Generic;

namespace BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>()
            {
                new Crow(),
                new Penguin()
            };

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird.Draw());
                Console.WriteLine(bird.SetLocation(20, 50));
                if (bird is ICanFly)
                {
                    Console.WriteLine(((ICanFly)bird).SetAltitude(40));
                }
            }
            Console.ReadKey();
        }
    }
}
