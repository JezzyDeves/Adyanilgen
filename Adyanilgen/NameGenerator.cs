using System;

namespace Adyanilgen
{
    public class NameGenerator
    {
        Phonetics _phonetics = new Phonetics();
        Random GetRandom = new Random();
        public string BasicSyllable()
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
    }
}
