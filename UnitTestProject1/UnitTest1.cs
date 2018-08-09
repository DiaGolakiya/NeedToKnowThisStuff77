using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeedToKnowThisStuff;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        GameCode myGameCode = new GameCode();
        [TestMethod]
        public void TestMethod1()
        {
            //expected
            //actual
            //assert

            int actual = myGameCode.RNDgenerator();

            Assert.IsTrue(actual > 0 && actual < 7);

            Assert.IsFalse((actual !< 0 ));
        }
    }
}
