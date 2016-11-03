using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HelloWorld.Tests
{
    [TestClass]
    public class ProgramTest
    {

        [TestMethod]
        public void TestCreateMessage()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }



    }
}
