using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        public void Construct(GroundBuilder builder) 
        {
            builder.BuildGallery();
            builder.BuildGroundSurface();
            builder.BuildAudience();
        }
    }
}
