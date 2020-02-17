using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
                23, 24, 25, 26, 27, 28,
                29, 30, 31
            };
            int pos = BinarySearch(list, 34);
            Console.WriteLine(pos);

            Console.ReadKey();
        }

        static int BinarySearch(List<int> list, int val)
        {
            int low = 0;
            int high = list.Count - 1;
            int mid = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                int guess= list[mid];
                if (guess == val) return mid;
                if (guess > val) high = mid - 1;
                else low = mid + 1;
            }
            return -1;
        }
    }
}