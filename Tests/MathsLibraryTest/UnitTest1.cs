using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace MathsLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivisibleByTwo()
        {
            int[] evens = { 0,2,4,-2 };
            foreach(var num in evens)
            {
                Assert.IsTrue(num.divisibleByTwo());
            }

            int[] unevens = {-1,1,3,311};
            foreach(var num in unevens)
            {
                Assert.IsFalse(num.divisibleByTwo());
            }

        }

    }
}
