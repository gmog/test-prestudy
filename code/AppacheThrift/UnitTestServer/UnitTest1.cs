using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ApacheThriftServer;

namespace UnitTestServer
{
    [TestClass]
    public class UnitTest1
    {

        StorageServiceHandler storageServiceHandler;
        int count;

        [TestInitialize]
        public void Initialize()
        {
            storageServiceHandler = new StorageServiceHandler();
            count = storageServiceHandler.StoragePointCount();
        }



        [TestMethod]
        public void TestStorageCount()
        {
            var storage = new StorageServiceHandler();
            var list = storage.storagePoints();
            Assert.IsTrue(list.Count==3, "Storage Points Count Mismatch");

        }



        [TestMethod]
        public void TestClearStorage()
        {
            storageServiceHandler.ClearStoragePoint();
            count = storageServiceHandler.StoragePointCount();
            Assert.IsTrue(count == 0, "Storage Is Not Cleared!");


        }






    }
}
