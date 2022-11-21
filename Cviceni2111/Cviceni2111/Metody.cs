using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2111
{
    public static class Metody
    {
        public delegate bool Condition(int number);

        public static IEnumerable<int> Select(this List<int> list, Condition condition)
        {
            foreach(int number in list)
            {
                if (condition(number))
                {
                    yield return number;
                }
            }
        }
    }
}
