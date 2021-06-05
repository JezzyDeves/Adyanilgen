using System.Collections.Generic;

namespace Adyanilgen.LanguageGen
{
    /// <summary>
    /// This class is where the phonetics used in the generation of words are stored
    /// </summary>
    public class Phonetics
    {
        public List<string> Vowels = new List<string>
        {
            "ah", "u", "ae", "e", "i"
        };
        public List<string> Consanants = new List<string>
        {
            "p", "f", "sh", "th", "j", "r", "l", "y", "n", "m", "x", "h"
        };
    }
}
