using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter first number");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
             num2 = int.Parse(Console.ReadLine());
            var result = num1 > num2 ? "first number is greater" : "second number is greater";
            Console.WriteLine(result);
            Console.ReadKey();





        }
    }
}
