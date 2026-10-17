using System;
using System.Collections.Generic;
using System.Text;

namespace _7__2_
{
    internal static class CollectionHelper
    {
        public static void PrintReverse<T>(this IList<T> arr)
        {
            for (int i = arr.Count - 1; i > 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        public static T GetFirstElement<T>(this IList<T> arr)
        {
            return arr[0];
        }
        public static T GetLastElement<T>(this IList<T> arr)
        {
            return arr[arr.Count - 1];
        }
        public static bool ContainsElement<T>(this IEnumerable<T> arr, T element)
        {
            bool co = int.TryParse(Console.ReadLine(), out int f);
            foreach (var item in arr)
            {
                if (item.Equals(f))
                {
                    return true;
                }
                ;
            }
            ;
            return default;
        }
        public static int CountElements<T>(this IEnumerable<T> arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                count++;
            }
            return count;
        }
        public static int FindIndex<T>(this IList<T> arr)
        {
            ;
            int ind = -1;
            bool In = int.TryParse(Console.ReadLine(), out int c);

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Equals(c))
                {
                    ind = i;
                }
            }
            return ind;
        }
    }
}
