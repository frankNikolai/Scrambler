using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scrambler.Classes.Tests
{
    [TestClass()]
    public class EncryptTests
    {
        Encrypt encrypt = new Encrypt();
        bool actual = true, expected = true;

        [TestMethod()]
        public void EncryptionAlgorithmNumberWordTestCorrectData()
        {
            string text = "encrypt", key = "";

            actual = encrypt.EncryptionAlgorithmNumberWord(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void EcryptionAlgorithmNumberWordTestIncorectData()
        {
            actual = expected = false;
            string text = "", key = "encrypt";

            actual = encrypt.EncryptionAlgorithmNumberWord(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void EcryptionAlgorithmNumberWordTestBorderData()
        {
            actual = expected = false;
            string text = "encrypt", key = "decrypt";

            actual = encrypt.EncryptionAlgorithmNumberWord(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }


        [TestMethod()]
        public void EncryptionAlgorithmCodeNumberTestCorrectData()
        {
            string text = "encrypt", key = "";

            actual = encrypt.EncryptionAlgorithmCodeNumber(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void EcryptionAlgorithmCodeNumberTestIncorrectData()
        {
            actual = expected = false;
            string text = "", key = "decrypt";

            actual = encrypt.EncryptionAlgorithmCodeNumber(ref text, ref key);

            Assert.AreEqual(actual, expected);
            
        }
        [TestMethod()]
        public void EcryptionAlgorithmCodeNumberTestBorderData()
        {
            actual = expected = false;
            string text = "encrypt", key = "decrypt";

            actual = encrypt.EncryptionAlgorithmCodeNumber(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }


        [TestMethod()]
        public void EncryptionAlgorithmCodeASCIITestCorrectData()
        {
            string text = "encrypt", key = "";

            actual = encrypt.EncryptionAlgorithmCodeASCII(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void EncryptionAlgorithmCodeASCIITestIncorrectData()
        {
            actual = expected = false;
            string text = "", key = "encrypt";

            actual = encrypt.EncryptionAlgorithmCodeASCII(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void EncryptionAlgorithmCodeASCIITestBorderData()
        {
            actual = expected = false;
            string text = "encrypt", key = "decrypt";

            actual = encrypt.EncryptionAlgorithmCodeASCII(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
    }
}