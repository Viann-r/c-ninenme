using System.Numerics;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] arr1 = { 1, 40, 29, -11, 6, -3, 15, 92, 30, 500 };
            int positive = 0;
            int negative = 0;
            int zeros = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                {
                    positive++;
                } else
                {
                    negative++;
                }
                ;
                if (arr1[i] % 10 == 0)
                {
                    zeros++;
                }
            }
            Console.WriteLine("1");
            Console.WriteLine($"positive numbers: {positive}");
            Console.WriteLine($"negative numbers: {negative}");
            Console.WriteLine($"zeros: {zeros}");


            //2

            int[] arr2 = { 8, 39, 50, 30, 2, 101, 83, 200 };
            int sum = 0;
            int ar = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                sum += arr2[i];
                if (i == arr2.Length - 1)
                {
                    ar = sum / arr2.Length;
                }
            }
            Console.WriteLine("2");
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"average: {ar}");


            //3

            int[] arr3 = { 7, 2, 15, 4, 9, 21, 3 };
            int min = 0;
            int max = 0;
            bool end1 = false;
            bool end2 = false;
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    if (arr3[i] >= arr3[j])
                    {
                        max = arr3[i];
                    } else
                    {
                        break;
                    }
                    if ( j == arr3.Length-1 )
                    {
                        end1 = true;
                    }
                }
                if (end1 == true) { break; }
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    if (arr3[i] <= arr3[j])
                    {
                        min = arr3[i];
                    }
                    else
                    {
                        break;
                    }
                    if (j == arr3.Length - 1)
                    {
                        end2 = true;
                    }
                }
                if (end2 == true) { break; }
            }
            Console.WriteLine("3");
            Console.WriteLine($"max: {max}");
            Console.WriteLine($"min: {min}");


            //4

            int[] arr4 = { 8, 38, 69, 2, -6, 9, 85, 900 };
            int sum1 = 0;
            for (int i = 0; i < arr4.Length; i++)
            {
                if (arr4[i] > 5)
                {
                    sum1 += arr4[i];
                };
            }
            Console.WriteLine("4");
            Console.WriteLine($"sum of numbers greater than 5: {sum1}");




            //5



            int[] arr5 = { 2, 5, 2, 7, 8, 2, 5, 2 };
            Console.WriteLine("5");
            Console.WriteLine("write number");
            bool n = int.TryParse(Console.ReadLine(), out int num);
            int count = 0; 
            for (int i = 0; i < arr5.Length; i++)
            {
               if (arr5[i] == num)
                {
                    count++;
                };
            }
            Console.WriteLine($"count of {num}: {count}");



            //6

            int[] grades = { 91, 55, 73, 42, 88, 67, 100, 49 };
            int passed = 0;
            int failed = 0;
            int excellent = 0;
            for ( int i = 0; i < grades.Length; i++)
            {
               if (grades[i] >= 51)
                {
                    passed++;
                } else
                {
                    failed++;
                }
               if (grades[i] >= 90)
                {
                    excellent++;
                };
            }
            Console.WriteLine("6");
            Console.WriteLine($"passed: {passed}");
            Console.WriteLine($"failed: {failed}");
            Console.WriteLine($"high grade: {excellent}");


            //7


            int[] numbers1 = { -3, 5, -8, 10, 0, -2 };
            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] <0)
                {
                    numbers1[i] = 0;
                };
            }
            Console.WriteLine("7");
            for (int i = 0; i < numbers1.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{numbers1[i]}");
                } else
                {
                    Console.Write($", {numbers1[i]}");
                }
            };


            //8


            int[] numbers2 = { 5, 12, 3, 25, 8, 19 };
            int max1 = 0;
            int max2 = 0;
            bool end = false;
            for (int i = 0; i < numbers2.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers2[i] >= numbers2[j])
                    {
                        max1 = numbers2[i];
                    }
                    else
                    {
                        break;
                    }
                    if (j == numbers2.Length - 1)
                    {
                        end = true;
                    }
                }
                if (end == true) { break; }
            }
            bool ends = false;
            for (int i = 0; i < numbers2.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers2[i] == max1) { break; }
                    if (numbers2[j] == max1) { j++; }
                    if (numbers2[i] >= numbers2[j])
                    {
                        max2 = numbers2[i];
                    }
                    else
                    {
                        break;
                    }
                    if (j == numbers2.Length - 1)
                    {
                        ends = true;
                    }
                }
                if (ends == true) { break; }
            }
            Console.WriteLine("");
            Console.WriteLine("8");
            Console.WriteLine($"first largest: {max1}");
            Console.WriteLine($"second largest: {max2}");
        }
    }
}
