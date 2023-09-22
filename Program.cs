using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num01;
            int num02;
            Console.WriteLine("type a number to be multiplied:");
            num01 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("type another number:");
            num02 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("the result is "+ num01 * num02);
            Console.ReadKey();




        }
    }
}
