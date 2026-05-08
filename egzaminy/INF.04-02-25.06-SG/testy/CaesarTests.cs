using _2025_czerwiec_02_konsola;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarTests
{
    [TestClass]
    public class CaesarTests
    {
        [TestMethod]
        public void ShouldEncryptBasicText()
        {
            Assert.AreEqual("def", Caesar.CaesarCipher("abc", 3));
        }

        [TestMethod]
        public void ShouldWrapAroundAlphabet()
        {
            Assert.AreEqual("abc", Caesar.CaesarCipher("xyz", 3));
        }

        [TestMethod]
        public void ShouldDecryptBasicText()
        {
            Assert.AreEqual("abc", Caesar.CaesarCipher("def", -3));
        }

        [TestMethod]
        public void ShouldEncryptWithKeyLargerThanAlphabetLength()
        {
            Assert.AreEqual("def", Caesar.CaesarCipher("abc", 29));
        }

        [TestMethod]
        public void ShouldKeepSpacesWhenEncrypting()
        {
            Assert.AreEqual("cd ef", Caesar.CaesarCipher("ab cd", 2));
        }
    }
}
