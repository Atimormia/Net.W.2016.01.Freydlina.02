using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tasks.Tests
{
    [TestClass]
    public class SolverTests
    {
        [TestMethod]
        public void Task1_PositiveConditions_Return3()
        {
            var a = new int[] { 1, 2, 3, 4, 3, 2, 1 };

            int expected = 3;

            int actual = Solver.Task1(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_ArrWithNegativeNumbers_Renurn1()
        {
            var a = new int[] { 1, 100, 50, -51, 1, 1 };

            int expected = 1;

            int actual = Solver.Task1(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_NegativeConditions_ReturnNot1()
        {
            var a = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int expected = -1;

            int actual = Solver.Task1(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
