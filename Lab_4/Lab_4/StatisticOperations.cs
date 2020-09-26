using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    static class StatisticOperations
    {
        public static int Max(this MySet set)
        {
            int len = set.GetItemByIndex(0).Length;
            foreach (string item in set.GetHash())
            {
                if (len < item.Length)
                    len = item.Length;
            }
            return len;
        }

        public static int Min(this MySet set)
        {
            int len = set.GetItemByIndex(0).Length;
            foreach (string item in set.GetHash())
            {
                if (len > item.Length)
                    len = item.Length ;
            }
            return len;
        }

        public static int Dif(this MySet set)
        {
            return Max(set) - Min(set);
        }

public static int CountOfWords(this string str)
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                count += words.Length;
            return count;
        }

        public static int Sum(this MySet set)
        {
            int len = 0;
            foreach(string item in set.GetHash())
            {
                len += item.Length;
            }
            return len;
        }

        public static void CommaAfterWord(this MySet set)
        {
            int len = set.GetSize();
            HashSet<string> res = new HashSet<string>();
            string buf = "";
            for(int i = 0; i < len; i++)
            {
                buf = set.GetItemByIndex(i);
                res.Add(buf);
                res.Add(",");
            }
            //foreach (string item in res)
            //{
            //    Console.WriteLine(item);
            //}
            set.collection = res;
        }

        public static void RemoveSpace(this MySet set)
        {
            set.collection.Remove("");
        }
    }
}
