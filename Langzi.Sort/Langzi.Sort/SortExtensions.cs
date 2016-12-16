﻿
namespace Langzi.Sort
{
    public  static class SortExtensions
    {
        /// <summary>
        /// 交换两个数值
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private static void Swap(ref int first, ref int second)
        {
            first ^= second;
            second ^= first;
            first ^= second;
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void BubbleSort(this int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 1; j < arr.Length - i; j++)
                    if (arr[j - 1] > arr[j])
                        Swap(ref arr[j - 1], ref arr[j]);
        }
        /// <summary>
        /// 冒泡排序优化
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort_Efficient(this int[] arr)
        {
            bool flag = true;
            for (int i = 0; flag && i < arr.Length - 1; i++)
            {
                flag = false;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
                        flag = true;
                    }
                }
            }
        }

    }
}