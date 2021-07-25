using System.Collections.Generic;
using System.Linq;

namespace N_ableDotNet
{
    public static class Filters
    {
        public static IEnumerable<int> OnlyEvenNumbers(IEnumerable<int> collection)
        {
            return collection.Where(x => x % 2 == 0);
        }

        public static IEnumerable<string> StringStartWithLetter(IEnumerable<string> collection, char letter = 'a')
        {
            letter = char.ToLower(letter);
            return collection.Where(x => char.ToLower(x.FirstOrDefault()) == letter);
        }
    }
}
