using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplePrograms.Logic
{
    [TestClass]

    public class SortTests
    {
        Sort sort;
        int[] array;

        [TestInitialize]
        public void Setup()
        {
            sort = new Sort();
            array = new int[] { 9, 2, 5, 3, 1 };
        }

        [TestMethod]
        public void SortArray_WhenCalled_ReturnsASorteArray()
        {
            

            var result = sort.SortArray(array);

            CollectionAssert.AreEqual(result, new int[] { 1, 2, 3, 5, 9 });


        }

        [TestMethod]
        public void SortArray_WhenCalled_ReturnsArray()
        {
     

            var result = sort.SortArray(array);

            Assert.IsNotNull(result);
            


        }

    }
}
