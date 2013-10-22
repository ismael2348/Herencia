using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class hija : padre
    {
        string piel;
        public void color()
        {
            Console.WriteLine("Cual es tu color de piel :");
            this.piel = Console.ReadLine();



            Console.WriteLine("\n\nColor de piel:   " + this.piel);

        }
    }
}
