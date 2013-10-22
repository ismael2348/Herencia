using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class padre
    {
        string nombre;
        string edad;
        string sexo;
        public void informacion (){
      
            Console.WriteLine("Cual es tu nombre :");
            nombre = Console.ReadLine();
            Console.WriteLine("Cual es tu edad :");
            edad = Console.ReadLine();
            Console.WriteLine("Cual es tu sexo :");
            sexo = Console.ReadLine();

            Console.WriteLine("\nTu nombre es:  " + this.nombre + "\nTu edad es:   " + this.edad + "\nTu sexo es : " + this.sexo);
        
        }



    }
}
