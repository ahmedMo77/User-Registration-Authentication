using System;
using System.Collections.Generic;

namespace UserRegistrationLogin
{
    class Program
    {
        static Dictionary<string, User> users = new Dictionary<string, User>();
        public class User
        {
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        static void RegisterUser()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (users.ContainsKey(email))
            {
                Console.WriteLine("This email is already registered. Please log in.");
                return;
            }

            User newUser = new User { Username = username, Email = email, Password = password };
            users[email] = newUser;
            Console.WriteLine("Registration successful!");
        }
        static void LoginUser()
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (users.ContainsKey(email) && users[email].Password == password)
            {
                Console.WriteLine("Login successful! Welcome " + users[email].Username);
            }
            else
            {
                Console.WriteLine("Invalid email or password.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select opton: ");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterUser();
                        break;
                    case "2":
                        LoginUser();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
