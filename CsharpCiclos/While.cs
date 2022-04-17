using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCiclos
{
    internal class While
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While mientras se verdadero se sigue ejecutando");

            var i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Foreach para trabajar con colecciones");

            foreach (var item in new[] {1,2,3,4,5})
            {
                Console.WriteLine(item);
            }
        }
    }
}
