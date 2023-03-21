using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SunnyGround: GroundBuilder
    {
        Ground ground = new();

        public override void BuildGallery()
        {
            ground.Add("Sunny images");
        }
        public override void BuildGroundSurface()
        {
            ground.Add("Dry ground surface");
        }
        public override void BuildAudience()
        {
            ground.Add("Audience in sunny weather");
        }
        public override Ground BuildGround()
        {
            return ground;
        }
    }
}
