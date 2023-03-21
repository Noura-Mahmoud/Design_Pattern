using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Position
    {
        int x, y, z;
        public Position(int X = 0, int Y = 0, int Z=0)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }
}
