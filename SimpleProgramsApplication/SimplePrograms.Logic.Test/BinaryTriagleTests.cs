using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePrograms.Logic
{
    [TestClass]
  
    public class BinaryTriagleTests
    {
        BinaryTriagle binaryTriagle;

        [TestInitialize]
        public void SetUp()
        {
            binaryTriagle = new BinaryTriagle();
        }

        [TestMethod]
        public void GenerateBinaryTriangle_GivenNumberOfRows_RetunsTriangleContainingThatNumber()
        {
             binaryTriagle.GenerateBinaryTriangle(5);

            var array = binaryTriagle.Triangle.GetLength(0);

            Assert.AreEqual(array, 5);
        }

        [TestMethod]
        public void GenerateBinaryTriangle_Whencalled_RetunsTriangleContainingBinaryValues()
        {
            binaryTriagle.GenerateBinaryTriangle(5);

            var array = binaryTriagle.Triangle;

            var binaries = GetElements(array,5);

            Assert.AreEqual(binaries,"10101");
        }

        private string GetElements(int[,] array,int number)
        {
            string binaries=string.Empty;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                 binaries += array[number-1, i].ToString();
            }

            return binaries;
        }

    }
}
