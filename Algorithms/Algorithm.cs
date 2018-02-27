using System;
using System.Collections.Generic;

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

          public static int Factorial(int i)
          {
               if(i == 1)
               {
                    return 1;
               }
               return i * Factorial(i - 1);
          }

          public static int FactorialNonRecur(int operand)
          {
               int result = 1;
               for (int i = 2; i <= operand; i++)
               {
                    result = result * i;
               }
               return result;
          }

          public static void TraverseBTInOrder(BinaryNode<string> node, List<string> result)
          {
               if(node != null)
               {
                    if(node.Left != null)
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
               string[] givens = input[0].Replace('[',' ').Replace(']', ' ').Split(',');
               int left = Int32.Parse(givens[0].Trim());
               int right = Int32.Parse(givens[1].Trim());
               int diff = Math.Abs(left - right);

               string[] usewts = input[1].Replace('[', ' ').Replace(']', ' ').Split(',');
               int[] options = new int[usewts.Length];
               for(int i = 0; i < usewts.Length; i++)
               {
                    options[i] =  Int32.Parse(usewts[i].Trim());
               }
               Array.Sort(options);

               //can you do it with one weight?
               for( int i = 0; i < options.Length; i++ )
               {
                    if(options[i] == diff)
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
               // If so, return true, otherwise return false.
               char[] chars = s.ToCharArray();
               for (int i = 0; i < chars.Length - 1; i++)
               {
                    if (Char.IsNumber(chars[i]))
                    {
                         int counter = 0;
                         for (int j = i + 1; j < chars.Length; j++)
                         {
                              if(chars[j] == '?')
                              {
                                   counter++;
                              }
                              if (Char.IsNumber(chars[j]))
                              {
                                   if (Char.GetNumericValue(chars[i]) + Char.GetNumericValue(chars[j]) == 10){
                                        if(counter != 3)
                                        {
                                             return false;
                                        }
                                   }
                                   else
                                   {
                                        break;
                                   }
                              }

                         }
                    }
               }
               return true;
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
     }  //class
}  //namespace
