using System;
using System.Collections.Generic;

namespace CScharpColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EDITAR POSICION POR POSICION
            Console.WriteLine("Editando vector por vector");
            int[] listaDeNumeros = new int[5];
            listaDeNumeros[0] =1;
            listaDeNumeros[1] =2;
            listaDeNumeros[2] =3;
            listaDeNumeros[3] =4;
            listaDeNumeros[4] =5;

            for (int i = 0; i < listaDeNumeros.Length; i++)
            {
                Console.WriteLine(listaDeNumeros[i]);
            }
            Console.WriteLine("Inicializando vectores");
            //INICIALIZAR VECTOR
            int[] numeros = new int[5] {1,2,3,4,5}; 
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("Ejercicio");

            string[] ejemplo1 = new string[3];

            for (int i = 0; i < ejemplo1.Length; i++)
            {
                Console.WriteLine("Trabajadores");
                ejemplo1[i] = Console.ReadLine();
            }

            var cantidadTrabajadores = ejemplo1.Length;
            Console.WriteLine("Por foreach");
            foreach (var item in ejemplo1)
            {
                Console.WriteLine($"trabajadores {item}");
            }
            Console.WriteLine("Por while");

            var cantidadTrabajadores2 = (ejemplo1.Length)-1;
            while (cantidadTrabajadores2 >= 0)
            {
               Console.WriteLine( ejemplo1[cantidadTrabajadores2]);
                cantidadTrabajadores2--;
            }

            Console.WriteLine($"cantidad de trabajadores es {cantidadTrabajadores}");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Diccionarios");


            var listaDatos = new Dictionary<string, string>();

            string valorDigitado = "";
            while (valorDigitado != ".")
            {
                Console.WriteLine("ingrese . para terminar");
                valorDigitado = Console.ReadLine();
                if (valorDigitado != ".")
                {
                    try
                    {
                        listaDatos.Add(Guid.NewGuid().ToString(), valorDigitado);

                    }catch(Exception)
                    {
                        Console.WriteLine("El dato ingresado no esta dentro o ya existe");
                    }
                }
            }

            foreach (var item in listaDatos)
            {
                Console.WriteLine($"La clave es {item.Key} y el valor es {item.Value}");
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("LISTAS");

            List<short> listaDePorcentajes = new List<short>();

            listaDePorcentajes.Add(50);
            listaDePorcentajes.Add(30);
            listaDePorcentajes.Add(70);
            foreach(var item in listaDePorcentajes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
