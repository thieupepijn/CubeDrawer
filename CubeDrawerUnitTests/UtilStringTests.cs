using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeDrawer;

namespace CubeDrawerUnitTests
{
    [TestClass]
    public class UtilStringTests
    {
        [TestMethod]
        public void NumberOfCharactersEqualTest()
        {
            Assert.AreEqual(UtilString.NumberOfCharactersEqual("LBF", "LTF"), 2);
            Assert.AreEqual(UtilString.NumberOfCharactersEqual("RBF", "LTB"), 0);
        }
    }
}
