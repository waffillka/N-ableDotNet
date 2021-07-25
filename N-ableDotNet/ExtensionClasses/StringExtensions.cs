using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ableDotNet.ExtensionClasses
{
    public static class StringExtensions
    {
        public static int StartsWithLetter(this string str, char c = 'a')
        {
            c = char.ToLower(c);
            return str.Split(new char[] { ' ', ',', '.', '?', '!' }).Where(x => char.ToLower(x.FirstOrDefault()) == c).Count();
        }

        public static int CountCharacters(this string str, char c)
        {
            c = char.ToLower(c);
            return str.Count(x => char.ToLower(x) == c);
        }

        public static int CountLetters(this string str) => str.Count(x => char.IsLetter(x));

        public static int CountDigit(this string str) => str.Count(x => char.IsDigit(x));
    }
}
