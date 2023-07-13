
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int attempts = 3;
                string validUsername = "viya";
                string validPassword = "kav346";

                while (attempts > 0)
                {
                    Console.WriteLine("Enter username: ");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter password: ");
                    string password = Console.ReadLine();

                    if (username == validUsername && password == validPassword)
                    {
                        Console.WriteLine("Login successful.");
                        return; // Exit the program
                    }
                    else if (username == validUsername && password != validPassword)
                    {
                        Console.WriteLine("Invalid password.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid username.");
                    }

                    attempts--;
                    Console.WriteLine("Attempts remaining: " + attempts);
                }

                Console.WriteLine("Login failed.");
            }
        }

    }
