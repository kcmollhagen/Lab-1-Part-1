using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //ask for and read input to assign to variables
            Console.WriteLine("Input a three digit number");
            int num1 = int.Parse(Console.ReadLine());

            int a1 = num1 / 100;
            int a2 = (num1 / 10) % 10;
            int a3 = num1 % 10;

            Console.WriteLine("Input another three digit number");
            int num2 = int.Parse(Console.ReadLine());

            int b1 = num2 / 100;
            int b2 = (num2 / 10) % 10;
            int b3 = num2 % 10;

            Console.WriteLine(CheckSums(a1, a2, a3, b1, b2, b3));

            Console.ReadKey();

        }
        public static bool CheckSums(int a1, int a2, int a3, int b1, int b2, int b3)
        {

            int asum = a1 + b1;
            int bsum = a2 + b2;
            int csum = a3 + b3;
            if (asum == bsum && bsum == csum)
                return true;
            else
                return false;
        }

    }
}