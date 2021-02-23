using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    public abstract class Bird
    {
        public abstract string Draw();
        public abstract string SetLocation(double longitude, double latitude);
    }
}
