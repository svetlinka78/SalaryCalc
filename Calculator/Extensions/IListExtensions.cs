using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Extensions
{
    public static class IListExtensions
    {
        public static IList<T> SingletonList<T>(this IList<T> iList, T item)
        {
            return Enumerable.Range(0, 1).Select(i => item).ToList().AsReadOnly();

            // or
            var Result = new List<T>();
            Result.Add(item);
            return Result.AsReadOnly();
        }
    }
}
