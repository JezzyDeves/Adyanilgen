using Adyanilgen.LanguageGen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class WordGeneratorTests
    {
        [TestMethod]
        public void BasicSyllable_ShouldReturnExpectedResult()
        {
            var syllable = WordGenerator.Syllable();

            Assert.IsTrue(syllable.Contains(syllable));
        }

        [TestMethod]
        public void ShouldThrowArgumentNullException_GivenNullArray()
        {
            Assert.ThrowsException<NullReferenceException>(() => WordGenerator.Syllable(null));
        }

        [TestMethod]
        public void ShouldThowArgumentOutOfRangeException_GivenInvalidParameters()
        {
            var chars = new char[] { 'a', 'b', 'c' };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WordGenerator.Syllable(chars));
        }

        [TestMethod]
        public void GenerateWord()
        {
            var word = WordGenerator.Word();

            Assert.IsNotNull(word);
        }
    }
}
