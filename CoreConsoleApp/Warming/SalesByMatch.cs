using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreConsoleApp
{
    public class SalesByMatch :IPractice
    {
        private int sockMerchant(int n, int[] ar)
        {
            int x = 0;
            int y = 0;
            int totalPairs = 0;
            List<int> colors = new List<int>();
            colors = ar.OfType<int>().ToList();

            foreach (var item in colors.Distinct())
            {
                x = 0;
                foreach (var item1 in ar)
                {
                    if (item == item1)
                    {
                        x++;
                    }
                }
                y = x / 2;
                totalPairs += y;
            }
            return totalPairs;
        }
        public void Run()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
