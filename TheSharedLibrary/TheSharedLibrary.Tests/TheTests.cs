using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheSharedLibrary.Tests
{
    [TestClass]
    public class TheTests
    {
        [TestMethod]
        public void TestThatMyNameIsChris()
        {
            var theName = "Chris";
            var sharedclass = new SharedClass();

            var result = sharedclass.SayMyName(theName);

            Assert.AreEqual(string.Format("Your name is {0}", theName), result);
        }
    }
}
