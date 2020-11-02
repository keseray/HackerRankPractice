using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleApp
{
    public class RepeatedString : IPractice
    {
        public void Run()
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            long result = RepeatedStringF(s, n);

            Console.WriteLine(result);

        }

        private long RepeatedStringF(string s, long n)
        {
            int lenghtOfStr = s.Length;
            long remain = n % lenghtOfStr;
            long aCount = s.Split('a').Length-1;
            string remainingStr = s.Substring(0, Convert.ToInt32(remain));
            long result = (aCount * (n / lenghtOfStr)) + (remainingStr.Split('a').Length - 1);
            return result;
        }
    }
}
