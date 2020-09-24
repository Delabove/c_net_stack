using Microsoft.VisualStudio.TestTools.UnitTesting;
using c_net_stack;

namespace c_net_stack_test
{
    [TestClass]
    public class DelayneListTests
    {
        private DelayneList list;

        [TestInitialize]
        public void Setup()
        {
            list = new DelayneList();
        }

        //push //pop //isEmpty //display //peek


        //Red //Green //Refactor

        //simplest test first 

        [TestMethod]
        public void IsEmpty_OnInstance_ShouldReturnTrue()
        {
            Assert.IsTrue(list.IsEmpty);
        }
    }
}
