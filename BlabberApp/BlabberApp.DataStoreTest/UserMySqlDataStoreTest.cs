using System;
using BlabberApp.DataStore;
using BlabberApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class UserMySqlDataStoreTest
    {
        [TestMethod]
        public void TestCanary()
        {
            Assert.IsTrue(true);
        }   
        [TestMethod]
        public void TestCreateSuccess()
        {
            // arrange
            var expected = new UserEntity();
            var fixture = new UserMySqlDataStore();
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.Create(expected));
        }   
        [TestMethod]
        public void TestDeleteSuccess()
        {
            // arrange
            var fixture = new UserMySqlDataStore();
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.Delete("0-0-0-0-0"));
        }   
        [TestMethod]
        public void TestReadSuccess()
        {
            // arrange
            var expected = new UserEntity();
            var fixture = new UserMySqlDataStore();
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.Read("0-0-0-0-0"));
        }   
        [TestMethod]
        public void TestReadAllSuccess()
        {
            // arrange
            var expected = new UserEntity();
            var fixture = new UserMySqlDataStore();
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.ReadAll());
        }   
        [TestMethod]
        public void TestUpdateSuccess()
        {
            // arrange
            var expected = new UserEntity();
            var fixture = new UserMySqlDataStore();
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.Update(expected));
        }   
    }
}