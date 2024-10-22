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
            Console.Write("number1");
            int number1=int.Parse(Console.ReadLine());
            Console.Write("number2=");
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine($"sum= {sum}";
            Console.Read();
        }
    }
}
