using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class MergeSorter
    {
        public static void DoMergeSort(int[] arr)
        {
            var sortedNumbers = MergeSort(arr);

            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                arr[i] = sortedNumbers[i];

            }

        }
        private static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr; // bace case

            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2<0)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }
            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return Merge(left, right);
        }

        internal static int DoMergeSort()
        {
            throw new NotImplementedException();
        }

        static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (NotEmpty(left) && NotEmpty(right))
            {
                if (left.First() <= right.First())
                    MoveValueFromSourceToResult(left, result);
                else
                    MoveValueFromSourceToResult(right, result);
            }
            while (NotEmpty(left))
            {
                MoveValueFromSourceToResult(left, result);
            }

            while (NotEmpty(right))
            {
                    MoveValueFromSourceToResult(right, result);
            }
            return result.ToArray();
        }

        private static bool NotEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void MoveValueFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
