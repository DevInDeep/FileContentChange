using System;
using System.Collections.Generic;

namespace FileChecksum.Extensions
{
    public static class EnumerableExtensions
    {
        public static void Do<T>(this IEnumerable<T> enumerable, Action<T> onItem)
        {
            foreach (var item in enumerable)
                onItem(item);
        }
    }
}
