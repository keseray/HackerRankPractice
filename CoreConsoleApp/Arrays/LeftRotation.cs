using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreConsoleApp.Arrays
{
    public class LeftRotation : IPractice
    {
        public void Run()
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));
        }

        private int[] rotLeft(int[] a, int d)
        {
            int[] a1 = new int[d];
            int[] a2 = new int[a.Length - d];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i <= d-1)
                {
                    a1[i] = a[i];
                }
                else
                {
                    a2[index] = a[i];
                    index++;
                }
            }

            return a2.Concat(a1).ToArray();

        }
    }
}
