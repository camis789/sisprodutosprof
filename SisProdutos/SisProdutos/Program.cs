using System;
using SisProdutos.models;
using SisProdutos.Service;

namespace SisProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            UserService userService = new UserService();

            //Listar usuarios
            var resultListUser = userService.ListUsers();

            foreach (var item in resultListUser)
            {
                Console.WriteLine("Nome: " + item.Name);
            }

            //Login
            /*Console.WriteLine("Digite email");
            user.Email = Console.ReadLine();

            Console.WriteLine("Digite senha");
            user.Password = Console.ReadLine();

            var resultAuth = userService.Auth(user);

            if (resultAuth)
            {
                Console.WriteLine("Logado");
            }
            else
            {
                Console.WriteLine("Incorreto");
            }

            //Adcionar usuario
            Console.WriteLine("Digite nome");
            user.Name = Console.ReadLine();

            Console.WriteLine("Digite email");
            user.Email = Console.ReadLine();

            Console.WriteLine("Digite Password");
            user.Password = Console.ReadLine();

            user.Access = Access.admin;

            userService.AddUser(user);

            Console.WriteLine("Retorno ok");
            Console.ReadLine();*/

        }
    }
}
