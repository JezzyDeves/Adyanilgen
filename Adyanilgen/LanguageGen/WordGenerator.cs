using System;

namespace Adyanilgen.LanguageGen
{
    public static class WordGenerator
    {
        private static Phonetics _phonetics = new Phonetics();
        private static Random GetRandom = new Random();

        /// <summary>
        /// Creates a basic syllable using the predefined syllable structure (consanant, vowel consanant, consanant)
        /// </summary>
        /// <returns></returns>
        public static string Syllable()
        {
            string syllable = "";

            char[] syllableStructure = new char[] { 'c', 'v', 'c', 'c' };

            foreach (var item in syllableStructure)
            {
                if (item.Equals('c'))
                {
                    var index = GetRandom.Next(_phonetics.Consanants.Count);
                    syllable += _phonetics.Consanants[index];
                }
                else
                {
                    var index = GetRandom.Next(_phonetics.Vowels.Count);
                    syllable += _phonetics.Vowels[index];
                }
            }

            return syllable;
        }
        /// <summary>
        /// Allows user to define custom syllable structure using a character array. Array must be made up of c for a consanant and v for vowel
        /// </summary>
        /// <param name="syllableStructure"></param>
        /// <returns></returns>
        public static string Syllable(char[] syllableStructure)
        {
            string syllable = "";
            syllable = VerifySyllable(syllableStructure, syllable);

            return syllable;
        }

        public static string Word()
        {
            var syllableCount = GetRandom.Next(1, 3);
            string word = string.Empty;

            while (syllableCount > 0)
            {
                var syllable = Syllable();

                syllableCount -= 1;

                word += syllable;
            }

            return word;
        }

        private static string VerifySyllable(char[] syllableStructure, string syllable = "")
        {
            foreach (var item in syllableStructure)
            {
                if (item.Equals('c'))
                {
                    var index = GetRandom.Next(_phonetics.Consanants.Count);
                    syllable += _phonetics.Consanants[index];
                }
                else if (item.Equals('v'))
                {
                    var index = GetRandom.Next(_phonetics.Vowels.Count);
                    syllable += _phonetics.Vowels[index];
                }
                else if (syllableStructure.Equals(null))
                {
                    throw new NullReferenceException();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            return syllable;
        }
    }
}
