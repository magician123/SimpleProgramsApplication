using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SimplePrograms.Logic
{
    [TestClass]
    public class StringManipulationTests
    {
        private StringManipulation stringManipulation;

        [TestInitialize]
        public void SetUp()
        {
            stringManipulation = new StringManipulation();
        }

        [TestMethod]
        public void CountCharacterOccurance_WhenCalled_ReturnNumberOfCharacters()
        {
            var result = stringManipulation.CountCharacterOccurance("Hello World");

            var firstValue = result.FirstOrDefault();
            var thirdValue = result.ElementAt(2);
            var forthValue = result.ElementAt(3);


            Assert.AreEqual(firstValue.Value, 1);
            Assert.AreEqual(thirdValue.Value, 3);
            Assert.AreEqual(forthValue.Value, 2);

        }

        [TestMethod]
        public void CountCharacterOccurance_WhenCalled_DoesNotReturnNull()
        {
            var result = stringManipulation.CountCharacterOccurance("Hello World");

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RemoveDuplicateCharacter_WhenCalled_RemovesRepeatingCharacters()
        {

            var result = stringManipulation.RemoveDuplicatedCharacter("Tshepiso Marape");

            Assert.AreEqual(result, "TshepioMar");


        }
    }
}
