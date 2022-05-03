using HomeWork.Class06.Task02.Models;
using HomeWork.Class06.Task02.Services;
using System;

namespace HomeWork.Class06.Task02
{
    class Program
    {
        public static void Main(string[] args)
        {

            User[] users = new User[3];
            UserService userService = new UserService();
            Console.WriteLine("Menu");
            Console.WriteLine("1. login");
            Console.WriteLine("2. register");
            int.TryParse(Console.ReadLine(), out int selection);

            while (selection > 0 && selection < 3)
            {
                switch(selection)
                {
                    case 1:
                        Console.WriteLine("123");
                        users = userService.Login("", "", users);
                        break;
                    case 2:
                        users = userService.Register(users);
                        break;
                    default:
                        Console.WriteLine("Please select a valid option!");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
