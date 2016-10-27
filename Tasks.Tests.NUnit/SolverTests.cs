using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tasks.Tests.NUnit
{
    [TestFixture]
    public class SolverTests
    {
        #region Test method: public static int Task1(int[] arr)
        public static IEnumerable<TestCaseData> TestCasesForTask1
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 3, 4, 3, 2, 1 }).Returns(3);
                yield return new TestCaseData(new int[] { 1, 100, 50, -51, 1, 1 }).Returns(1);
                yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5, 6, 7 }).Returns(-1);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForTask1))]
        public int TestTask1(int[] arr)
        {
            return Solver.Task1(arr);

        }
        #endregion

        #region Test method: public static string LongestTask2(string a, string b)
        public static IEnumerable<TestCaseData> TestCasesForTask2
        {
            get
            {
                yield return new TestCaseData("xyaabbbccccdefww", "xxxxyyyyabklmopq").Returns("abcdefklmopqwxy");
                yield return new TestCaseData("abcdefghijklmnopqrstuvwxyz", "").Returns("abcdefghijklmnopqrstuvwxyz");
                yield return new TestCaseData("1234","3456").Returns("123456");
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForTask2))]
        public string TestTask2(string a, string b)
        {
            return Solver.LongestTask2(a,b);

        }
        #endregion

        #region Test method: public static int InsertionTask3(int a, int b, int i, int j)
        public static IEnumerable<TestCaseData> TestCasesForTask3
        {
            get
            {
                yield return new TestCaseData(8, 15, 0, 0).Returns(9);
                yield return new TestCaseData(0, 15, 30, 30).Returns(1073741824);
                yield return new TestCaseData(0, 15, 0, 30).Returns(15);
                yield return new TestCaseData(15, -15, 0, 4).Returns(31);
                yield return new TestCaseData(15, int.MaxValue, 3, 5).Returns(63);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForTask3))]
        public int TestTask3(int a, int b, int i,int j)
        {
            return Solver.InsertionTask3(a, b, i, j);

        }
        #endregion
    }
}
