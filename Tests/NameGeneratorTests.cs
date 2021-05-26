using Adyanilgen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class NameGeneratorTests
    {
        private NameGenerator _nameGen;

        [TestInitialize]
        public void Arrange()
        {
            _nameGen = new NameGenerator();
        }

        [TestMethod]
        public string Act()
        {
            return _nameGen.BasicSyllable();
        }

        [TestMethod]
        public void BasicSyllable_ShouldReturnExpectedResult()
        {
            var syllable = Act();

            Assert.IsTrue(syllable.Contains(syllable));
        }
    }
}
