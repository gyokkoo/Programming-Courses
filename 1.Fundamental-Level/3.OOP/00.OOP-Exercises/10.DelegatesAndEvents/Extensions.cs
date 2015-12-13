using System;
using System.Collections.Generic;

namespace _10.DelegatesAndEvents
{
    public static class Extensions
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var element in collection)
            {
                if (predicate(element))
                {
                    return element;
                }
            }

            return default(T);
        }

        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var element in collection)
            {
                if (predicate(element))
                {
                    result.Add(element);
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var element in collection)
            {
                action(element);
            }
        }
    }
}
