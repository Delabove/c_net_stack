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

        //add //remove //size  //get 


        //Red
        //Green
        //Refactor

        //simplest test first 

        [TestMethod]
        public void Size_OnInstance_ShouldReturnZero()
        {
            Assert.AreEqual(0, list.Size());
        }


        [TestMethod]
        public void Size_AddOneElement_ShouldReturn1()
        {
            list.add(1);
            Assert.AreEqual(1, list.Size());
        }


    }
}
