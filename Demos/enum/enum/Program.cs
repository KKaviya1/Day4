using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Seasons
        {
        Winter,
        summer,
        rainy
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Current season is : " + Seasons.rainy);
            Console.WriteLine("Season Number is : " + (int)Seasons.rainy);
            Console.ReadKey();
        }
    }
}
