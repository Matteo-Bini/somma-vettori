using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somma_vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vettori v1 = new Vettori(3, 5);
            Vettori v2 = new Vettori(4, 6);
            Console.WriteLine(v1+v2);
            Console.ReadLine();
        }

        



    }
}
