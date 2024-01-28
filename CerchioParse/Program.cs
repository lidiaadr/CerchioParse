using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerchioParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Cerchio c = Cerchio.Parse(a);
            Console.WriteLine(c.Area());
            Console.WriteLine(c.Perimetro());

            Console.ReadLine();
        }
    }
}
