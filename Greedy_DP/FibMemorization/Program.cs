using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, BigInteger> alreadyCalc = new Dictionary<int, BigInteger>();

            Console.Write(Fib(n, alreadyCalc));
        }

        static BigInteger Fib(int num, Dictionary<int, BigInteger> alreadyCalc)
        {
            if (num <= 1)   return num;
            if (alreadyCalc.ContainsKey(num))   return alreadyCalc[num];

            BigInteger result = Fib(num - 1, alreadyCalc) + Fib(num - 2, alreadyCalc);
            alreadyCalc.Add(num, result);
            return result;
        }
    }
}
