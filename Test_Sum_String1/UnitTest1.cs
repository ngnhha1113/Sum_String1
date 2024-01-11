using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Unittest()
        {
            string check1 = MyBigNumber.String_Sum("9482394", "4782394");
            Assert.AreEqual(check1, "14264788");

            string check2 = MyBigNumber.String_Sum("9482394", "0");
            Assert.AreEqual(check2, "9482394");
        }
    }
}

