using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleApp.Arrays
{
    public class NewYearChaos : IPractice
    {
        public void Run()
        {
            MinimumBribes();
            //int t = Convert.ToInt32(Console.ReadLine());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            //    MinimumBribes(q);
            //}
        }

        private void MinimumBribes(int[] q = null)
        {
            q = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };
            int bribeCount = 0;
            bool isValid = true;
            for (int i = 0; i < q.Length - 1; i++)
            {
                if (q[i] - i > 3)
                {
                    isValid = false;
                    break;
                }

                for (int j = i + 1; j < q.Length; j++)
                {
                    if (q[j] < q[i])
                    {
                        bribeCount++;
                    }
                }
            }


            //for (int i = 0; i < q.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < q.Length; j++)
            //    {
            //        if (q[j] < q[i])
            //        {
            //            bribeCount++;
            //        }
            //    }
            //}

            if (!isValid)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine(bribeCount);
            }
        }
    }
}
