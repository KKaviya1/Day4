using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myJArray = new int[3][];
            myJArray[0] = new int[3] {12,11,13 };
            myJArray[1] = new int[5] { 10, 12, 13 ,10, 11};
            myJArray[2] = new int[2] { 0, 5};
            for (int i = 0; i < myJArray.Length; i++)
            {
                for (int j = 0; j < myJArray.Length; j++)
                {
                    Console.WriteLine(myJArray[i][j] + "\t");
                }
                    Console.WriteLine("\t");

                }
                Console.ReadKey();
            }
        }

    }

