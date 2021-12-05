using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scrambler.Classes.Tests
{
    [TestClass()]
    public class DecryptTests
    {
        Decrypt decrypt = new Decrypt();
        bool actual = true, expected = true;

        [TestMethod()]
        public void DecryptionAlgorithmNumberWordTestCorrectData()
        {
            string text = "encrypt", key = "decrypt";

            actual = decrypt.DecryptionAlgorithmNumberWord(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void DecryptionAlgorithmNumberWordTestIncorectData()
        {
            actual = expected = false;
            string text = "decrypt", key = "";

            actual = decrypt.DecryptionAlgorithmNumberWord(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void DecryptionAlgorithmNumberWordTestBorderData()
        {
            actual = expected = false;
            string text = "decrypt", key = "";

            actual = decrypt.DecryptionAlgorithmNumberWord(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }


        [TestMethod()]
        public void DecryptionAlgorithmCodeNumberTestCorrectData()
        {
            string text = "decrypt", key = "encrypt";

            actual = decrypt.DecryptionAlgorithmCodeNumber(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void DecryptionAlgorithmCodeNumberTestIncorrectData()
        {
            actual = expected = false;
            string text = "decrypt", key = "";

            actual = decrypt.DecryptionAlgorithmCodeNumber(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void DecryptionAlgorithmCodeNumberTestBorderData()
        {
            actual = expected = false;
            string text = "", key = "decrypt";

            actual = decrypt.DecryptionAlgorithmCodeNumber(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }


        [TestMethod()]
        public void DecryptionAlgorithmCodeASCIITestCorrectData()
        {
            string text = "decrypt123456", key = "1234567";

            actual = decrypt.DecryptionAlgorithmCodeASCII(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void DecryptionAlgorithmCodeASCIITestIncorrectData()
        {
            actual = expected = false;
            string text = "decrypt", key = "encrypt";

            actual = decrypt.DecryptionAlgorithmCodeASCII(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void DecryptionAlgorithmCodeASCIITestBorderData()
        {
            actual = expected = false;
            string text = "key", key = "12345f";

            actual = decrypt.DecryptionAlgorithmCodeASCII(ref text, ref key);

            Assert.AreEqual(actual, expected);
        }
    }
}