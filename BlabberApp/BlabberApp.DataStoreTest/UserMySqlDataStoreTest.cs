using System;
using System.Collections.Generic;
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
            var fixture = new UserMySqlDataStore(new MySqlDataStoreConnection(
                "Server=143.110.159.170;Port=3306;Database=donstringham;Uid=donstringham;Pwd=letmein;"
            ));
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.Create(expected));
        }   
        [TestMethod]
        public void TestDeleteSuccess()
        {
            // arrange
            var fixture = new UserMySqlDataStore(new MySqlDataStoreConnection(
                "Server=143.110.159.170;Port=3306;Database=donstringham;Uid=donstringham;Pwd=letmein;"
            ));
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.Delete("0-0-0-0-0"));
        }   
        [TestMethod]
        public void TestReadSuccess()
        {
            // arrange
            var expected = new UserEntity();
            var fixture = new UserMySqlDataStore(new MySqlDataStoreConnection(
                "Server=143.110.159.170;Port=3306;Database=donstringham;Uid=donstringham;Pwd=letmein;"
            ));
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.Read("0-0-0-0-0"));
        }   
        [TestMethod]
        public void TestReadEmpty()
        {
            // arrange
            var expected = new UserEntity();
            var fixture = new UserMySqlDataStore(new MySqlDataStoreConnection(
                "Server=143.110.159.170;Port=3306;Database=donstringham;Uid=donstringham;Pwd=letmein;"
            ));
            // act
            UserEntity actual = (UserEntity)fixture.Read("0a23f006-3631-44d0-bf12-cabb03aee11d");
            // assert
            Assert.AreEqual(expected.Name, actual.Name);
        }   
        [TestMethod]
        public void TestReadAllSuccess()
        {
            // arrange
            var expected = new List<UserEntity>().ToArray();
            var fixture = new UserMySqlDataStore(new MySqlDataStoreConnection(
                "Server=143.110.159.170;Port=3306;Database=donstringham;Uid=donstringham;Pwd=letmein;"
            ));
            // act
            var actual = fixture.ReadAll();
            // assert
            Assert.AreEqual(expected, actual);
        }   
        [TestMethod]
        public void TestUpdateSuccess()
        {
            // arrange
            var expected = new UserEntity();
            var fixture = new UserMySqlDataStore(new MySqlDataStoreConnection(
                "Server=143.110.159.170;Port=3306;Database=donstringham;Uid=donstringham;Pwd=letmein;"
            ));
            // act and assert
            Assert.ThrowsException<NotImplementedException>(() => fixture.Update(expected));
        }   
    }
}