using System;
using Palindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "anna";
            bool expected = true;
            bool actual = Program.isPalindromeOrAnagramOfPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string input = "aaaaaaaa";
            bool expected = true;
            bool actual = Program.isPalindromeOrAnagramOfPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string input = "aaaaaaaab";
            bool expected = true;
            bool actual = Program.isPalindromeOrAnagramOfPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string input = "caaaaaaaab";
            bool expected = false;
            bool actual = Program.isPalindromeOrAnagramOfPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string input = "donotbobtonod";
            bool expected = true;
            bool actual = Program.isPalindromeOrAnagramOfPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string input = "owefhijpfwai";
            bool expected = false;
            bool actual = Program.isPalindromeOrAnagramOfPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string input = "igdedgide";
            bool expected = true;
            bool actual = Program.isPalindromeOrAnagramOfPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            string input = "silentsiltn";
            bool expected = true;
            bool actual = Program.isPalindromeOrAnagramOfPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
