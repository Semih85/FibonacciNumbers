using System;

namespace FibonacciNumber
{
    internal class Program
    {
        static long numCalls = 0;

        static void Main(string[] args)
        {

            const int n = 80;

            Console.WriteLine(n + ". fibonacci number with loop: " + CalcFibonacciInLoop(n));
            //Console.WriteLine(n + ". fibonacci number: " + CalcFibonacci(n));
            Console.WriteLine(n + ". fibonacci number with formula: " + CalcFibonacciFormula(n));

            Console.ReadLine();
        }

        /// <summary>
        /// This formula gives nth fibonacci sequence using arrays. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long CalcFibonacciInLoop(int n)
        {
            long[] fibonacci = new long[n];

            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                //Console.WriteLine(fibonacci[i]);
            }

            return fibonacci[n - 1];
        }

        /// <summary>
        ///  A recursive formula to calculate nth fibonacci sequence. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static long CalcFibonacci(int n)
        {
            numCalls++;

            if (n < 1)
            {
                throw new ArgumentException("Fibonacci funtion is not defined for " + n);
            }

            if (n == 1 || n == 2) return 1;

            return CalcFibonacci(n - 2) + CalcFibonacci(n - 1);
        }

        /// <summary>
        /// This formula gives nth fibonacci sequence. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static long CalcFibonacciFormula(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("Fibonacci funtion is not defined for " + n);
            }

            if (n == 1 || n == 2) return 1;

            double t = Math.Sqrt(5);
            double p1 = 1 / t;
            double p2 = (1 + t) / 2;
            double p3 = (1 - t) / 2;

            return (long)(p1 * (Math.Pow(p2, n) - Math.Pow(p3, n)));
        }
    }
}
