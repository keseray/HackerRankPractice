using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreConsoleApp.DictionariesAndHashMap
{
    public class TwoStrings : IPractice
    {
        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();
                string result = TwoStringsF(s1, s2);

                Console.WriteLine(result);
            }

        }

        private string TwoStringsF(string s1, string s2)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            int counter = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (!charCount.ContainsKey(s1[i]))
                {
                    charCount.Add(s1[i], 1);
                }
                else
                {
                    charCount[s1[i]]++;
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (charCount.ContainsKey(s2[i]))
                {
                    counter++;
                }
            }

            if (counter>0)
            {
                return "YES";
            }
            return "NO";

            //bool isContain = s1.Any(c => s2.Contains(c));

            //if (isContain)
            //{
            //    return "YES";
            //}
            //else
            //{
            //    return "NO";
            //}
        }
    }
}
