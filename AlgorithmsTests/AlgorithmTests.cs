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
               string desired = "dcba";
               string result = Algorithm.ReverseString1(original);
               Assert.AreEqual(result, desired);
          }

          [TestMethod]
          public void ReverseString1Test()
          {
               string original = "abcd";
               string desired = "dcba";
               string result = Algorithm.ReverseString1(original);
               Assert.AreEqual(result, desired);
          }

          [TestMethod]
          public void ReverseString2Test()
          {
               string original = "abcd";
               string desired = "dcba";
               string result = Algorithm.ReverseString2(original);
               Assert.AreEqual(result, desired);
          }

          [TestMethod]
          public void FactorialRTest()
          {
               int original = 12;
               int desired = 479001600;
               DateTime start = DateTime.Now;
               int result = Algorithm.Factorial(original);
               DateTime end = DateTime.Now;
               Debug.WriteLine(end - start);
               Assert.AreEqual(result, desired);
          }

          [TestMethod]
          public void FactorialNRTest()
          {
               int original = 12;
               int desired = 479001600;
               DateTime start = DateTime.Now;
               int result = Algorithm.FactorialNonRecur(original);
               DateTime end = DateTime.Now;
               Debug.WriteLine(end - start);
               Assert.AreEqual(result, desired);
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

               List<string> desired = new List<string> { "A", "B", "C", "D", "E", "F", "G" };
               List<string> result = new List<string>();
               Algorithm.TraverseBTInOrder(nodes[3], result);
               for(int i = 0; i < result.Count; i++)
               {
                    Assert.AreEqual(result[i], desired[i]);
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

               List<string> desired = new List<string> { "D", "B", "A", "C", "F", "E", "G" };
               List<string> result = new List<string>();
               Algorithm.TraverseBTPreOrder(nodes[3], result);
               for (int i = 0; i < result.Count; i++)
               {
                    Assert.AreEqual(result[i], desired[i]);
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

               List<string> desired = new List<string> { "A", "C", "B", "E", "G", "F", "D" };
               List<string> result = new List<string>();
               Algorithm.TraverseBTPostOrder(nodes[3], result);
               for (int i = 0; i < result.Count; i++)
               {
                    Assert.AreEqual(result[i], desired[i]);
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
               Assert.AreEqual(result1, "1");
               Assert.AreEqual(result2, "3,6");
               Assert.AreEqual(result3, "not possible");
          }

     }
}
