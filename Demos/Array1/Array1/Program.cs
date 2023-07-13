using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 50, 60, 75, 83, 98 };

            Console.WriteLine("*marks lists*");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1} \t Marks: {marks[i]}");

            }
            Console.ReadKey();
        }

    }
}
