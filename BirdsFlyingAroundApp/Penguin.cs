using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    class Penguin : Bird
    {
        public override string Draw()
        {
            return "Crow is on the screen.";
        }

        public override string SetLocation(double longitude, double latitude)
        {
            return "Crow is now at: " + longitude + "," + latitude;
        }
    }
}
