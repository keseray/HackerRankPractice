using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreConsoleApp
{
    public class CountingValleys : IPractice
    {
        public void Run()
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = CountingValleysF(steps, path);

            Console.WriteLine(result);
        }

        private int CountingValleysF(int steps, string path)
        {
            int level = 0;
            int valleyCount = 0;
            foreach (var item in path)
            {
                int prevLevel = level;
                if (item == 'U')
                {
                    level++;
                }
                else
                {
                    level--;
                }

                if (prevLevel < 0 && level == 0)
                {
                    valleyCount++;
                }

            }
            return valleyCount;
        }
    }
}
