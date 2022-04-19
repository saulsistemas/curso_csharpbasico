using CSharpSocialNetWorkManage.Models;
using System;

namespace CSharpSocialNetWorkManage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppManager app = new AppManager();
            User user = new User();
            //var app = new AppManager();
            Console.WriteLine($"Bienvenido {app.appTitle}");
            Console.WriteLine("Ingrese su nombre");
            user.Name = Console.ReadLine();
            Console.WriteLine("Ingrese su email");
            user.Email = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad");
            user.Age =short.Parse( Console.ReadLine());
            
            Console.WriteLine($"Su nombre es {user.Name}");
            Console.WriteLine($"Su correo es {user.Email}");
            Console.WriteLine($"Su edad es {user.Age}");
            Console.WriteLine($"Esta activo {user.IsActive}");
            Console.WriteLine($"Fecha creacion {user.DateCreated}");

        }
    }
}
