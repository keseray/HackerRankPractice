using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleApp.DictionariesAndHashMap
{
    public class HashTablesRansomNote : IPractice
    {
        public void Run()
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            CheckMagazine(magazine, note);
        }

        private void CheckMagazine(string[] magazine, string[] note)
        {
            Hashtable ht = new Hashtable();
            bool isValid = true;



            foreach (var item in magazine)
            {
                var key = item.GetHashCode();

                if (ht.ContainsKey(key))
                {
                    var valueCount = (ValueCount)ht[key];
                    valueCount.Count++;
                    ht[key] = valueCount;
                }
                else
                {
                    var valueCount = new ValueCount() { Value = item, Count = 1 };
                    ht.Add(key, valueCount);
                }
            }

            foreach (var item in note)
            {
                var key = item.GetHashCode();
                var exist = ht.ContainsKey(key);
                if (!exist)
                {
                    isValid = false;
                    Console.WriteLine("No");
                    break;
                }
                else
                {
                    var valueCount = (ValueCount)ht[key];
                    valueCount.Count--;
                    if (valueCount.Count == 0)
                    {
                        ht.Remove(key);
                    }
                    else
                    {
                        ht[key] = valueCount;
                    }
                }
            }

            if (isValid)
            {
                Console.WriteLine("Yes");
            }

        }
        struct ValueCount
        {
            public string Value { get; set; }
            public int Count { get; set; }
        }
    }
}
