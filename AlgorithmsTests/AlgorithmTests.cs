using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlgorithmsTests
{
     [TestClass]
     public class AlgorithmTests
     {
          [TestMethod]
          public void ReverseString0Test()
          {
               string original = "abcd";
               string expected = "dcba";
               string result = Algorithm.ReverseString1(original);
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void ReverseString1Test()
          {
               string original = "abcd";
               string expected = "dcba";
               string result = Algorithm.ReverseString1(original);
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void ReverseString2Test()
          {
               string original = "abcd";
               string expected = "dcba";
               string result = Algorithm.ReverseString2(original);
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void FactorialRTest()
          {
               int original = 12;
               long expected = 479001600;
               DateTime start = DateTime.Now;
               long result = Algorithm.Factorial(original);
               DateTime end = DateTime.Now;
               Debug.WriteLine(end - start);
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void FactorialNRTest()
          {
               int original = 12;
               long expected = 479001600;
               DateTime start = DateTime.Now;
               long result = Algorithm.FactorialNonRecur(original);
               DateTime end = DateTime.Now;
               Debug.WriteLine(end - start);
               Assert.AreEqual(expected, result);
          }


          [TestMethod]
          public void FibonacciTest()
          {
               int n = 8;
               long expected = 21;
               long result = Algorithm.Fibonacci(n);
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void FibonacciNonRecurTest()
          {
               int n = 8;
               long expected = 21;
               long result = Algorithm.FibonacciNonRecur(n);
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void TraverseBTInOrderTest()
          {
               BinaryNode<string>[] nodes = new BinaryNode<string>[7];
               nodes[0] = new BinaryNode<string>("A");
               nodes[1] = new BinaryNode<string>("B");
               nodes[2] = new BinaryNode<string>("C");
               nodes[3] = new BinaryNode<string>("D");
               nodes[4] = new BinaryNode<string>("E");
               nodes[5] = new BinaryNode<string>("F");
               nodes[6] = new BinaryNode<string>("G");

               nodes[3].AddLeftNode(nodes[1]);
               nodes[3].AddRightNode(nodes[5]);
               nodes[1].AddLeftNode(nodes[0]);
               nodes[1].AddRightNode(nodes[2]);
               nodes[5].AddLeftNode(nodes[4]);
               nodes[5].AddRightNode(nodes[6]);

               List<string> expected = new List<string> { "A", "B", "C", "D", "E", "F", "G" };
               List<string> result = new List<string>();
               Algorithm.TraverseBTInOrder(nodes[3], result);
               for(int i = 0; i < result.Count; i++)
               {
                    Assert.AreEqual(expected[i], result[i]);
               }
          }

          [TestMethod]
          public void TraverseBTPreOrderTest()
          {
               BinaryNode<string>[] nodes = new BinaryNode<string>[7];
               nodes[0] = new BinaryNode<string>("A");
               nodes[1] = new BinaryNode<string>("B");
               nodes[2] = new BinaryNode<string>("C");
               nodes[3] = new BinaryNode<string>("D");
               nodes[4] = new BinaryNode<string>("E");
               nodes[5] = new BinaryNode<string>("F");
               nodes[6] = new BinaryNode<string>("G");

               nodes[3].AddLeftNode(nodes[1]);
               nodes[3].AddRightNode(nodes[5]);
               nodes[1].AddLeftNode(nodes[0]);
               nodes[1].AddRightNode(nodes[2]);
               nodes[5].AddLeftNode(nodes[4]);
               nodes[5].AddRightNode(nodes[6]);

               List<string> expected = new List<string> { "D", "B", "A", "C", "F", "E", "G" };
               List<string> result = new List<string>();
               Algorithm.TraverseBTPreOrder(nodes[3], result);
               for (int i = 0; i < result.Count; i++)
               {
                    Assert.AreEqual(expected[i], result[i]);
               }
          }

          [TestMethod]
          public void TraverseBTPostOrderTest()
          {
               BinaryNode<string>[] nodes = new BinaryNode<string>[7];
               nodes[0] = new BinaryNode<string>("A");
               nodes[1] = new BinaryNode<string>("B");
               nodes[2] = new BinaryNode<string>("C");
               nodes[3] = new BinaryNode<string>("D");
               nodes[4] = new BinaryNode<string>("E");
               nodes[5] = new BinaryNode<string>("F");
               nodes[6] = new BinaryNode<string>("G");

               nodes[3].AddLeftNode(nodes[1]);
               nodes[3].AddRightNode(nodes[5]);
               nodes[1].AddLeftNode(nodes[0]);
               nodes[1].AddRightNode(nodes[2]);
               nodes[5].AddLeftNode(nodes[4]);
               nodes[5].AddRightNode(nodes[6]);

               List<string> expected = new List<string> { "A", "C", "B", "E", "G", "F", "D" };
               List<string> result = new List<string>();
               Algorithm.TraverseBTPostOrder(nodes[3], result);
               for (int i = 0; i < result.Count; i++)
               {
                    Assert.AreEqual(expected[i], result[i]);
               }
          }

          [TestMethod]
          public void QuestionMarkTest()
          {
               string s1 = "arrb6???4xxbl5???eee5";
               bool result1 = Algorithm.QuestionMark(s1);
               string s2 = "acc?7??sss?3rr1??????5";
               bool result2 = Algorithm.QuestionMark(s2);
               string s3 = "5??aaaaaaaaaaaaaaaaaaa?5?5";
               bool result3 = Algorithm.QuestionMark(s3);
               string s4 = "9???1???9???1???9";
               bool result4 = Algorithm.QuestionMark(s4);
               string s5 = "aa6?9";
               bool result5 = Algorithm.QuestionMark(s5);
               Debug.WriteLine(result1.ToString() + result2.ToString() + result3.ToString() + result4.ToString() + result5.ToString());
               Assert.IsTrue(result1);
               Assert.IsTrue(result2);
               Assert.IsFalse(result3);
               Assert.IsTrue(result4);
               Assert.IsFalse(result5);

          }

          [TestMethod]
          public void BalanceScaleTest()
          {
               string[] input1 = { "[3, 4]", "[1, 2, 7, 7]" };
               string result1 = Algorithm.BalanceScale(input1);
               string[] input2 = { "[13, 4]", "[1, 2, 3, 6, 14]" };
               string result2 = Algorithm.BalanceScale(input2);
               string[] input3 = { "[13, 4]", "[1, 2, 10, 11, 14]" };
               string result3 = Algorithm.BalanceScale(input3);
               Debug.WriteLine("------------------");
               Debug.WriteLine(result1);
               Debug.WriteLine(result2);
               Debug.WriteLine(result3);
               Debug.WriteLine("------------------");
               Assert.AreEqual("1", result1);
               Assert.AreEqual("3,6", result2);
               Assert.AreEqual("not possible", result3);
          }

          [TestMethod]
          public void AppleStocksTest()
          {
               int[] prices1 = { 100, 110, 120, 155, 140, 105 };
               int[] prices2 = { 100, 110, 80, 70, 115, 130 };
               int[] prices3 = { 100, 50, 110, 40, 120 };
               int expected1 = 55;
               int expected2 = 60;
               int expected3 = 80;
               int result1 = Algorithm.AppleStocks(prices1);
               int result2 = Algorithm.AppleStocks(prices2);
               int result3 = Algorithm.AppleStocks(prices3);
               Assert.AreEqual(expected1, result1);
               Assert.AreEqual(expected2, result2);
               Assert.AreEqual(expected3, result3);
          }

          [TestMethod]
          public void ProductOfOtherNumbersTest()
          {
               int[] numbers1 = { 2, 3, 4, 5 };
               int[] numbers2 = { 5, 2, 4, 3 };
               int[] expected1 = { 60, 40, 30, 24 };
               int[] expected2 = { 24, 60, 30, 40 };
               int[] result1 = Algorithm.ProductOfOtherNumbers(numbers1);
               //int[] result2 = Algorithm.ProductOfOtherNumbers(numbers2);
               for (int i = 0; i < result1.Length; i++)
               {
                    Assert.AreEqual(expected1[i], result1[i]);
               }
               //for (int i = 0; i < result2.Length; i++)
               //{
               //     Assert.AreEqual(expected2[i], result2[i]);
               //}
          }

          [TestMethod]
          public void ProductOfOtherNumbersBruteTest()
          {
               int[] numbers1 = { 2, 3, 4, 5 };
               int[] numbers2 = { 5, 2, 4, 3 };
               int[] expected1 = { 60, 40, 30, 24 };
               int[] expected2 = { 24, 60, 30, 40 };
               int[] result1 = Algorithm.ProductOfOtherNumbersBrute(numbers1);
               int[] result2 = Algorithm.ProductOfOtherNumbersBrute(numbers2);
               for (int i = 0; i < result1.Length; i++)
               {
                    Assert.AreEqual(expected1[i], result1[i]);
               }
               for (int i = 0; i < result2.Length; i++)
               {
                    Assert.AreEqual(expected2[i], result2[i]);
               }
          }

          [TestMethod]
          public void HighestProductOfThreeTest()
          {
               int[] numbers1 = { 2, 3, 4, 5 };
               int[] numbers2 = { 5, 2, 4, 3 };
               int expected1 = 60;
               int expected2 = 60;
               int result1 = Algorithm.HighestProductOfThree(numbers1);
               int result2 = Algorithm.HighestProductOfThree(numbers2);
               Assert.AreEqual(expected1, result1);
               Assert.AreEqual(expected2, result2);
          }
     }  //class
}  //namespace
