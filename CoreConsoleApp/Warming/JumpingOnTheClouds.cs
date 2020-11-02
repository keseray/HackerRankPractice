using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleApp
{
    public class JumpingOnTheClouds : IPractice
    {
        public void Run()
        {
            //int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = JumpingOnClouds(c);

            Console.WriteLine(result);

        }

        private int JumpingOnClouds(int[] c)
        {
            int jumpingCount = 1;
            int i = 0;
            while (i < c.Length - 3)
            {
                jumpingCount++;
                if (c[i + 2] == 0)
                {
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            return jumpingCount;
        }
    }
}
