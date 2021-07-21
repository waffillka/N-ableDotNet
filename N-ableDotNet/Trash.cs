using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ableDotNet
{
    public static class Trash
    {
        public static void SwapTowNumbers(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
    }
}
