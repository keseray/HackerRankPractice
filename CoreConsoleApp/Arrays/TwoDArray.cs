using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreConsoleApp.Arrays
{
    public class TwoDArray : IPractice
    {
        public void Run()
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }

        private int hourglassSum(int[][] arr)
        {
            List<int> sumList = new List<int>();
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    sumList.Add(arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);

                }
            }

            int maxSum = sumList.ToArray().Max();
            return maxSum;
        }
    }
}
