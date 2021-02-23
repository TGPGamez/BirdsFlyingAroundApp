using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    class Crow : Bird, ICanFly
    {
        public override string Draw()
        {
            return "Crow is on the screen.";
        }

        public string SetAltitude(double altitude)
        {
            return "Crow is flying at: " + altitude + " meters in the sky";
        }

        public override string SetLocation(double longitude, double latitude)
        {
            return "Crow is now at: " + longitude + "," + latitude;
        }
    }
}
