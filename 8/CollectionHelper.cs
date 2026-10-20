using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    internal static class CollectionHelper
    {
        public static T Where<T>(this IEnumerable<T> collection, T el)
        {
            if (collection.Contains(el))
            {
                return el;
            }
            return default;
        }
        public static T FirstOrdefault<T>(this IEnumerable<T> collection, T el)
        {
            if (collection.Contains(el))
            {
                return el;
            }
            return el;
         }
        public static bool Any<T>(this IEnumerable<T> collection, T el)
        {
            if (collection.Contains(el))
            {
                return true;
            } else { return false; }
            return default;
        }

        public static bool All<T>(this IEnumerable<T> collection, T el)
        {
            bool al = true;
            foreach (var item in collection)
            {
                if (collection.Contains(el))
                {
                    return true;
                } else
                {
                    al = false;
                }
                if (al = false)
                {
                    return false;
                }
            }
            return default;
        }
        public static int Count<T>(this IEnumerable<T> collection, T el)
        {
            int c = 0;
            foreach (var item in collection)
            {
                if (collection.Contains(el))
                {
                    c++;
                }
            }
            return c;
        }
    }
}
