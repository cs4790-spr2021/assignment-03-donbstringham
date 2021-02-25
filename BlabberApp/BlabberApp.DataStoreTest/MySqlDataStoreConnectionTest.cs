using System;
using BlabberApp.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class MySqlDataStoreConnectionTest
    {
        [TestMethod]
        public void TestCanary()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestConstructor()
        {
            // arrange
            MySqlDataStoreConnection fixture = new MySqlDataStoreConnection(
                "Server=143.110.159.170;Port=3306;Database=donstringham;Uid=donstringham;Pwd=letmein;"
            );
            // act & assert
            try
            {
                fixture.Open();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
            try
            {
                fixture.Close();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }
    }
}
