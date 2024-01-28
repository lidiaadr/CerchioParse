using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerchioParse
{
    internal class Cerchio
    {
        public float Raggio { get; set; }

        public Cerchio(float raggio) 
        {
            Raggio = raggio;
        }

        public float Area()
        {
            return (float)(Math.PI * (Raggio*Raggio));
        }
        public float Perimetro()
        {
            return (float)(Math.PI * (2 * Raggio));
        }
        public override string ToString()
        {
            return string.Format("{0}", Raggio);
        }
        public static Cerchio Parse(string s)
        {
            string[] raggio = s.Split(new char[] { });
            int Raggio = int.Parse(raggio[0]);
            return new Cerchio(Raggio);
        }
    }
}
