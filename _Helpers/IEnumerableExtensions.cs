using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool Any(this IEnumerable enumerable)
        {
            return (enumerable.GetEnumerator().MoveNext() == true);
        }
    }
}
