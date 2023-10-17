using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method SieveOfEratosthenes Started");
            Console.WriteLine("------------------------------");
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine("Prime numbers in the range [2, {0}]:", n);
            foreach (int prime in primes)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Method SieveOfEratosthenes Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            return primes;
        }
    }
}
