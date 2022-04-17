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
            Console.WriteLine($"Su nombre es {user.Name}");
            Console.WriteLine($"Su correo es {user.Email}");

        }
    }
}
