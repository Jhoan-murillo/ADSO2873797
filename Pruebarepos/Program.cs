using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebarepos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite un numero");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) 
            {
                Console.WriteLine("el numero es par");
            }
            else
            {
                Console.WriteLine("el numero es impar");
            }
            Console.ReadKey();
        }
    }
}
