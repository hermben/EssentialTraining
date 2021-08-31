﻿using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EssentialTrainingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Class1();
            var testResult = testInstance.AddTwo(9, 5);
            Assert.AreEqual(testResult, 14, "I expect 9 + 5 to be 14");
        }
    }
}
