using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assgn_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                // Check if the number is positive, negative, or zero
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }

                // Check if the number is even or odd using the conditional operator
                string parity = (number % 2 == 0) ? "even" : "odd";
                Console.WriteLine("The number is " + parity + ".");
            }
        }
 }

