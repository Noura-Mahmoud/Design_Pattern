using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class RainyGround: GroundBuilder
    {
        Ground ground = new();

        public override void BuildGallery()
        {
            ground.Add("Rainy images");
            //Console.WriteLine("Rainy images");
        }
        public override void BuildGroundSurface()
        {
            ground.Add("Wet ground surface");
            //Console.WriteLine("Wet ground surface");
        }
        public override void BuildAudience()
        {
            ground.Add("Audience in rainy weather");
            //Console.WriteLine("Audience in rainy weather");
        }
        public override Ground BuildGround()
        {
            return ground;
        }

    }
}
