using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplePrograms.Logic
{
    [TestClass]

    public class ReveseStringTests
    {
        private ReverseString reverseString;

        [TestInitialize]
        public void SetUp()
        {
            reverseString = new ReverseString();
        }
        [TestMethod]
        public void Reverse_GivenString_Reversed()
        {

            var result = reverseString.Reverse("hello");
            Assert.AreEqual("olleh", result);

        }
    }
}
