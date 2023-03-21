using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Ground
    {
        List<string> parts= new List<string>();
        public void Add(string part) 
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\nGround parts: ");
            foreach(var part in parts) Console.WriteLine(part);
            Console.WriteLine("\n");
        }
    }
}
