using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ApacheThriftServer;

namespace UnitTestServer
{
    [TestClass]
    public class UnitTest1
    {

        StorageServiceHandler storageServiceHandler;

        [TestInitialize]
        public void Initialize()
        {
            storageServiceHandler = new StorageServiceHandler();
        }



        [TestMethod]
        public void TestStorageCount()
        {
            var storage = new StorageServiceHandler();
            var list = storage.storagePoints();
            Assert.IsTrue(list.Count==3);

        }





    }
}
