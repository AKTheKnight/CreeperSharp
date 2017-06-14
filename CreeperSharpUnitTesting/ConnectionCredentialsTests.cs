using System;
using CreeperSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreeperSharpUnitTesting
{
    [TestClass]
    public class ConnectionCredentialsTests
    {

        [TestMethod]
        public void TestConstructor()
        {
            var credentials = new ConnectionCredentials("key", "secret");

            Assert.AreEqual(credentials.Key, "key");
            Assert.AreEqual(credentials.Secret, "secret");
        }

        [TestMethod]
        public void TestSetters()
        {
            var credentials = new ConnectionCredentials("key", "secret");

            credentials.SetKey("keySetter");
            credentials.SetSecret("secretSetter");

            Assert.AreEqual(credentials.Key, "keySetter");
            Assert.AreEqual(credentials.Secret, "secretSetter");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithKeyNull()
        {
            var credentials = new ConnectionCredentials(null, "secret");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithSecretNull()
        {
            var credentials = new ConnectionCredentials("key", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSettingKeyNull()
        {
            var credentials = new ConnectionCredentials("key", "secret");

            credentials.SetKey(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSettingSecretNull()
        {
            var credentials = new ConnectionCredentials("key", "secret");

            credentials.SetSecret(null);
        }
    }
}
