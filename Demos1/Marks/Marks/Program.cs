using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks in pre: ");
            int preMarks = Convert.ToInt32(Console.ReadLine());

            if (preMarks > 60)
            {
                Console.WriteLine("Enter the marks in final: ");
                int finalMarks = Convert.ToInt32(Console.ReadLine());

                if (finalMarks > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Fail in Final");
                }
            }
            else
            {
                Console.WriteLine("Fail in Pre");
            }

            Console.ReadLine();
        }
    }
}