using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExpandArray()
        {
            BakkenList<string> bakkensList = new BakkenList<string>();
            string[] testArray = new string[] {"Fox"};
            bakkensList.Add("Fox");
            Assert.AreEqual(1, bakkensList.count);
        }
    }
}
