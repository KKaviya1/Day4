using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of students");
            int nos = int.Parse(Console.ReadLine());
            string[] students = new string[nos];
            for(int i=0; i< nos; i++)
            {
                Console.WriteLine($"enter students{i+1}\'s name");
                students[i] = Console.ReadLine();   

            }
            Console.WriteLine("list of students");
            foreach (string student in students)
            { Console.WriteLine(student); }
            Console.ReadKey();
        }
    }
}
