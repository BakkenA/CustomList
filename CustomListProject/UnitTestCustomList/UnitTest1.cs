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
            bakkensList.Add("Fox");
            Assert.AreEqual(1, bakkensList.count);
        }
       [TestMethod]
       public void ExpandAndFind()
        {
            BakkenList<string> bakkensList = new BakkenList<string>();
            bakkensList.Add("Velociraptor");
            bakkensList.Add("Utahraptor");
            bakkensList.Add("Oviraptor");
            //bakkensList.GetIndex("Utahraptor");
            bakkensList.RemoveAt(1);
            Assert.AreEqual(2, bakkensList.count);
        }
    }
}
