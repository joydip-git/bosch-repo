using System;
using System.Collections.Generic;

namespace EnumerableExtensionLibrary
{
    public static class EnumerableExtension
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> enumerable, Predicate<T> logicDel)
        {
            List<T> result = new List<T>();

            foreach (T item in enumerable)
            {
                if (logicDel(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
