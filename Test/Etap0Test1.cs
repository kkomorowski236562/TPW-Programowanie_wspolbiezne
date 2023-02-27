using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;



namespace Test
{
    [TestClass]
    public class Etap0Test1
    {
        private const string expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Hello.Hello.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}