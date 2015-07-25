using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_LINQ_Extension_Methods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(item => !predicate(item));
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection , Func<TSource, TSelector> func ) where TSelector:IComparable
        {
            if (collection==null)
            {
                throw new InvalidOperationException("Collection is empty");
            }
            TSelector max = func(collection.First());
            foreach (var item in collection)
            {
                if (max.CompareTo(func(item))<0)
                {
                    max = func(item);
                }
            }
            return max;
        }
    }
}
