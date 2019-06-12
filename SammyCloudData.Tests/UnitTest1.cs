using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SammyCloudData.DAL;
using SammyCloudData.Entities;

namespace SammyCloudData.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IndexedValuesDALGet()
        {
            Result<List<IndexedValue>> result = IndexedValuesRepository.Get();
            Assert.AreEqual(result.Success, true);
        }
    }
}
