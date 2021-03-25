using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemo;
namespace LinkedListUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindNode_with_value_30_should_return_node()
        {
         
            LinkedList list = new LinkedList();
           int value = list.Search(30);
            Assert.AreEqual(30,30);

        }
    }
}