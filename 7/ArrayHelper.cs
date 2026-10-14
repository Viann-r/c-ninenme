using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
    internal static class ArrayHelper
    {
        public static void PrintReverse<T>(this T[] arr) {
            for (int i = arr.Length - 1; i > 0; i--) {
                Console.Write($"{arr[i]} ");
            }
        }
        public static T GetFirstElement<T>(this T[] arr) {
            return arr[0];
        }
        public static T GetLastElement<T>(this T[] arr)
        {
            return arr[arr.Length - 1];
        }
        public static bool ContainsElement<T>(this T[] arr, T element)
        {
            bool co = int.TryParse(Console.ReadLine(), out int f);
            foreach (var item in arr)
            {
                if (item.Equals(f))
                {
                    return true;
                };
            };
            return default;
        }
        public static int CountElements<T>(this T[] arr) {
            int count = 0;
            foreach (var item in arr)
            {
                count++;
            }
            return count;
        }
        public static int FindIndex<T>(this T[] arr)
        {;
            int ind = -1;
            bool In = int.TryParse(Console.ReadLine(), out int c);
            for (int i = 0; i < arr.Length; i++)
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
