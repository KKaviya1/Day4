
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.WriteLine("enter marks");
            for(int i=0; i<marks.Length; i++)
            {
                Console.WriteLine( "enter marks in subject" +(i+1));
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*marks lists*");
            for(int i=0; i< marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1} \t Marks: {marks[i]}");

            }
            Console.ReadKey();
        }
    }
}
