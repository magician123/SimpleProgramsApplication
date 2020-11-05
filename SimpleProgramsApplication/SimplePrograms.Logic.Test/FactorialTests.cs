using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplePrograms.Logic
{
    [TestClass]
    public class FactorialTests
    {
        private Factorial factorial;
        [TestInitialize]
        public void SetUp()
        {
            factorial = new Factorial();
        }


        [TestMethod]
        public void FindFactorial_WhenPassedAnInteger_ReturnsAFactorial()
        {

            var result = factorial.FindFactorial(6);

            Assert.AreEqual(720, result);

        }
    }
}
