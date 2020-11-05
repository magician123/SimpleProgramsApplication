using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SimplePrograms.Logic
{
    [TestClass]
    public class ComputeNumbersTests
    {
        int[] array;
        ComputeNumbers computeNumbers;


        [TestInitialize]
        public void Setup()
        {
            computeNumbers = new ComputeNumbers();
            array = new int[] { 9, 2, 15, 99, 23 };
        }

        [TestMethod]
        public void GetMax_WhenCalled_ReturnsAGreaterNumber()
        {
            var result = computeNumbers.GetMax(array);

            Assert.AreEqual(result, 99);
        }

        [TestMethod]
        public void GetMin_WhenCalledReturnsTheSmallesNumber()
        {
            var result = computeNumbers.GetMin(array);

            Assert.AreEqual(result, 2);

        }

        [TestMethod]
        public void Fibonacci_WhenCalled_ReturnFibonacciSeries()
        {
            var result = computeNumbers.Fibonacci(9);

            var expectedList = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            CollectionAssert.AllItemsAreNotNull(result);
            CollectionAssert.AreEqual(expectedList, result);
            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));


        }

        [TestMethod]
        public void PrimeNumber_GivenPrimeNumber_ReturnsTrue()
        {
            var result = computeNumbers.IsPrimeNumber(5);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PrimeNumber_GivenNonPrimeNumber_ReturnsFalse()
        {
            var result = computeNumbers.IsPrimeNumber(6);

            Assert.IsFalse(result);
        }

    }
}
