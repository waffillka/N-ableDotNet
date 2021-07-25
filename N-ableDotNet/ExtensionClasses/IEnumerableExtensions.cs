using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace N_ableDotNet.ExtensionClasses
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> data, Func<T, bool> predicate)
        {
            foreach (T item in data)
            {
                if (predicate(item)) yield return item;
            }
        }
    }
}
