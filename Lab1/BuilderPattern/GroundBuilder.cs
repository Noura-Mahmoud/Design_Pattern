using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class GroundBuilder
    {
        public abstract void BuildGallery();
        public abstract void BuildGroundSurface();
        public abstract void BuildAudience();
        public abstract Ground BuildGround();

    }
}
