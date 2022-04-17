using System;

namespace Estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            string tamanio;
            string estudiandte;
            Console.WriteLine("Ingrese su edad");
            var edadUsuarioString =  Console.ReadLine();

            var mensaje = int.TryParse(edadUsuarioString, out int edadUsuario)? "calculando" : "Edad no";

            Console.WriteLine(mensaje);
            if (mensaje == "Edad no") return;


            Console.WriteLine("Escriba sexo");
            sexo = Console.ReadLine();

            Console.WriteLine("Escriba Tamaño A B");
            tamanio = Console.ReadLine();

            Console.WriteLine("Escriba Tipo Estudiante U E");
            estudiandte = Console.ReadLine();

            if (edadUsuario >= 18)
            {
                Console.WriteLine("Es mayor de edad");
                if (edadUsuario >=65)
                {
                    Console.WriteLine("Es de la tercera edad");
                }
            }
            else {
                Console.WriteLine("Es menor de edad");
            }



            //SI HAY DOS IF IF AMBOS SE vAN A EJECUTAR, MINTRAS QUE ELSE IF SIGUE EVALUANDO
        
            if(sexo == "M")
            {
                Console.WriteLine("Es Masculino");
            }
            else if (sexo == "F")
            {
                Console.WriteLine("Es Femenino");

            }
            else
            {
                Console.WriteLine("Es Raro");

            }
            // && AND //|| OR

            //IF MEJORADO
            if (tamanio == "A") Console.WriteLine("Es Alto");
            else if (tamanio == "B") Console.WriteLine("Es Bajo");
            else Console.WriteLine("Eres Chato");

            
        }
    }
}
