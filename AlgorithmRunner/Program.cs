using Algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmRunner
{
     class Program
     {
          static void Main(string[] args)
          {
               //DateTime time0 = DateTime.Now;
               //for (int n = 1; n < 45; n++)
               //{
               //     Console.WriteLine(Algorithm.Fibonacci(n));
               //}
               //DateTime time1 = DateTime.Now;
               //for (int n = 1; n < 45; n++)
               //{
               //     Console.WriteLine(Algorithm.FibonacciNonRecur(n));
               //}
               //DateTime time2 = DateTime.Now;
               //Console.WriteLine("Recursive: " + (time1 - time0));
               //Console.WriteLine("NonRecursive: " + (time2 - time1));
               //Console.ReadLine();

               int[] numbers = Enumerable.Range(1, 5000).ToArray();
               DateTime time0 = DateTime.Now;
               for (int n = 1; n < 100; n++)
               {
                    Console.WriteLine(Algorithm.ProductOfOtherNumbers(numbers));
               }
               DateTime time1 = DateTime.Now;
               for (int n = 1; n < 100; n++)
               {
                    Console.WriteLine(Algorithm.ProductOfOtherNumbersBrute(numbers));
               }
               DateTime time2 = DateTime.Now;
               Console.WriteLine("Elegant: " + (time1 - time0));
               Console.WriteLine("Brute: " + (time2 - time1));
               Console.ReadLine();

          }
     }
}
