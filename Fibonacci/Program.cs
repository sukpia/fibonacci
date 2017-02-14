using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the fibonacci series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            int firstNumber = 0, secondNumber = 1, result = 0;

            if (n == 0) return 0;
            if (n == 1) return 1;

            for (int i = 2; i <= n; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;
        }
    }
}
