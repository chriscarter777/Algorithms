using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Algorithms
{
     public static class Algorithm
     {
          public static string ReverseString0(string original)
          {
               char[] originalArray = original.ToCharArray();
               Array.Reverse(originalArray);
               return new string(originalArray);
          }

          public static string ReverseString1(string original)
          {
               char[] originalArray = original.ToCharArray();
               int size = originalArray.Length;
               char[] reversedArray = new char[size];
               for (int i = 0, j = (size - 1); i < size; i++, j--)
               {
                    reversedArray[j] = originalArray[i];
               }
               return new string(reversedArray);
          }

          public static string ReverseString2(string original)
          {
               char[] origArray = original.ToCharArray();
               for (int i = 0, j = (origArray.Length - 1); i < j; i++, j--)
               {
                    char c = origArray[i];
                    origArray[i] = origArray[j];
                    origArray[j] = c;
               }
               return new string(origArray);
          }

          public static long Factorial(int i)
          {
               if (i == 1)
               {
                    return 1;
               }
               return i * Factorial(i - 1);
          }

          public static long FactorialNonRecur(int operand)
          {
               int result = 1;
               for (int i = 2; i <= operand; i++)
               {
                    result = result * i;
               }
               return result;
          }

          public static long Fibonacci(int n)
          {
               if (n < 2) { return n; }
               else
               {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
               }
          }

          public static long FibonacciNonRecur(int n)
          {
               long[] f = new long[n + 1];
               f[0] = 0;
               f[1] = 1;
               for (int i = 2; i <= n; i++)
               {
                    f[i] = f[i - 1] + f[i - 2];
               }
               return f[n];
          }


          public static void TraverseBTInOrder(BinaryNode<string> node, List<string> result)
          {
               if (node != null)
               {
                    if (node.Left != null)
                    {
                         TraverseBTInOrder(node.Left, result);
                    }
                    result.Add(node.Value);
                    if (node.Right != null)
                    {
                         TraverseBTInOrder(node.Right, result);
                    }
               }
          }

          public static void TraverseBTPreOrder(BinaryNode<string> node, List<string> result)
          {
               if (node != null)
               {
                    result.Add(node.Value);
                    if (node.Left != null)
                    {
                         TraverseBTPreOrder(node.Left, result);
                    }
                    if (node.Right != null)
                    {
                         TraverseBTPreOrder(node.Right, result);
                    }
               }

          }

          public static void TraverseBTPostOrder(BinaryNode<string> node, List<string> result)
          {
               if (node != null)
               {
                    if (node.Left != null)
                    {
                         TraverseBTPostOrder(node.Left, result);
                    }
                    if (node.Right != null)
                    {
                         TraverseBTPostOrder(node.Right, result);
                    }
                    result.Add(node.Value);
               }
          }

          public static string BalanceScale(string[] input)
          {
               //Read string array which will contain two elements, 
               //the first being the two positive integer weights on a balance scale (left and right), and 
               //the second element being a list of available weights as positive integers. 
               //Your goal is to determine if you can balance the scale by using the least amount of weights from the list, at most 2 weights.
               //Your program should return a comma-separated string of the weights that were used from the list in ascending order.

               //There will only ever be one unique solution and the list of available weights will not be empty. 
               //Add weights to only one side of the scale to balance it. 
               //If it is not possible to balance the scale, return the string "not possible".

               //parse input string
               string[] givens = input[0].Replace('[', ' ').Replace(']', ' ').Split(',');
               int left = Int32.Parse(givens[0].Trim());
               int right = Int32.Parse(givens[1].Trim());
               int diff = Math.Abs(left - right);

               string[] usewts = input[1].Replace('[', ' ').Replace(']', ' ').Split(',');
               int[] options = new int[usewts.Length];
               for (int i = 0; i < usewts.Length; i++)
               {
                    options[i] = Int32.Parse(usewts[i].Trim());
               }
               Array.Sort(options);

               //can you do it with one weight?
               for (int i = 0; i < options.Length; i++)
               {
                    if (options[i] == diff)
                    {
                         return options[i].ToString();
                    }
               }

               //can you do it with two weights?
               for (int i = 1; i < options.Length; i++)
               {
                    for (int j = 0; j < i; j++)
                    {
                         if (options[i] + options[j] == diff)
                         {
                              //return ascending (options is sorted Asc)
                              return options[j].ToString() + "," + options[i].ToString();
                         }
                    }
               }
               return "not possible";
          }

          public static bool QuestionMark(string s)
          {
               // Take an input string parameter and determine if exactly 3 question marks exist between every pair of numbers that add up to 10.
               // If so, return true, otherwise return false.  Also return false if no adjacent pairs sum to 10.
               char[] chars = s.ToCharArray();
               int lastDigit = 0;
               int qCount = 0;
               bool tenPair = false;
               for (int i = 0; i < chars.Length; i++)
               {
                    if (Char.IsNumber(chars[i]))
                    {
                         if (Char.GetNumericValue(chars[i]) + lastDigit == 10)
                         {
                              if (qCount != 3) return false;
                              tenPair = true;
                         }
                         lastDigit = (int)Char.GetNumericValue(chars[i]);
                         qCount = 0;
                    }
                    if (chars[i] == '?') qCount++;
               }
               return tenPair ? true : false;
          }

          public static int AppleStocks(int[] prices)
          {
               int maxDiff = prices[0] * (-1);
               int minPrice = prices[0];
               for (int i = 1; i < prices.Length; i++)
               {
                    if (prices[i] - minPrice > maxDiff)  maxDiff = prices[i] - minPrice;
                    if (prices[i] < minPrice) minPrice = prices[i];
               }
               return maxDiff;
          }

          public static int[] ProductOfOtherNumbers(int[] numbers)
          {
               //use of division is disallowed
               int[] results = new int[numbers.Length];

               int[] beforeProd = new int[numbers.Length];
               beforeProd[0] = 1;
               for (int i = 1; i < numbers.Length; i++)
               {
                    beforeProd[i] = beforeProd[i - 1] * numbers[i - 1];
               }

               int[] afterProd = new int[numbers.Length];
               afterProd[numbers.Length - 1] = 1;
               for (int i = (numbers.Length - 2); i >= 0; i--)
               {
                    afterProd[i] = afterProd[i + 1] * numbers[i + 1];
               }

               for (int i = 0; i < numbers.Length; i++)
               {
                    results[i] = beforeProd[i] * afterProd[i];
               }
               return results;
          }

          public static int[] ProductOfOtherNumbersBrute(int[] numbers)
          {
               //use of division is disallowed
               int[] results = new int[numbers.Length];
               for (int i = 0; i < numbers.Length; i++)
               {
                    results[i] = 1;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                         if (j != i) results[i] = results[i] * numbers[j];
                    }
               }
               return results;
          }

          public static int HighestProductOfThree(int[] numbers)
          {
               int h0 = 0;
               int h1 = 0;
               int h2 = 0;
               for (int i = 0; i < numbers.Length; i++)
               {
                    if (numbers[i] > h0)
                    {
                         h2 = h1;
                         h1 = h0;
                         h0 = numbers[i];
                    }
                    else if (numbers[i] > h1)
                    {
                         h2 = h1;
                         h1 = numbers[i];
                    }
                    else if(numbers[i] > h2)
                    {
                         h2 = numbers[i];
                    }
               }
               return h0 * h1 * h2;
          }

          public static List<Appointment> CalendarMerge(List<Appointment> appts)
          {
               for (int i = 0; i < appts.Count - 1; i++)
               {
                    int j = i + 1;
                    while (j < appts.Count)
                    {
                         //j surrounds i
                         if (appts[j].Start <= appts[i].Start && appts[j].End >= appts[i].End)
                         {
                              appts[i].Start = appts[j].Start;
                              appts[i].End = appts[j].End;
                              appts.RemoveAt(j);

                         }
                         //j extends i end
                         else if (appts[j].Start >= appts[i].Start && appts[j].Start <= appts[i].End && appts[j].End >= appts[i].End)
                         {
                              appts[i].End = appts[j].End;
                              appts.RemoveAt(j);
                         }
                         //j extends i start
                         else if (appts[j].Start <= appts[i].Start && appts[j].End >= appts[i].Start && appts[j].End <= appts[i].End)
                         {
                              appts[i].Start = appts[j].Start;
                              appts.RemoveAt(j);
                         }
                         else
                         {
                              j++;
                         }
                    }  //j
               }  //i
               return appts;
          }

     }  //class




     public class BinaryNode<T>
     {
          public T Value { get; set; }
          public BinaryNode<T> Left { get; set; }
          public BinaryNode<T> Right { get; set; }

          public BinaryNode(T val)
          {
               Value = val;
          }


          public void AddLeftNode(BinaryNode<T> newNode)
          {
               Left = newNode;
          }

          public void AddRightNode(BinaryNode<T> newNode)
          {
               Right = newNode;
          }
     }  //BinaryNode<T> class

     public class Appointment
     {
          public int Start { get; set; }
          public int End { get; set; }

          public Appointment(int s, int e)
          {
               Start = s;
               End = e;
          }
     }  //Appointment class
}  //namespace
