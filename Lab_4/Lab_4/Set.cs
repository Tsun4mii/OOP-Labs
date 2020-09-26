using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab_4
{
    public class MySet
    {
        private readonly Owner owner;
        public HashSet<String> collection;
        private readonly Date date;
        public int Size;

        public MySet(int ownerId, string ownerFIO)
        {
            this.owner = new Owner(ownerId, ownerFIO);
            this.collection = new HashSet<string>();
            this.date = new Date();
        }

        public HashSet<string> GetHash()
        {
            return collection;
        }

        public void Show()
        {
            foreach(string item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public Owner GetOwner()
        {
            return owner;
        }

        public int GetSize()
        {
            int size = 0;
            foreach (string item in collection)
            {
                size++;
            }
            return size;
        }

        public void AddItem(string item)
        {
            collection.Add(item);
        }

        public class Date
        {
            public readonly DateTime time;

            public Date()
            {
                time = DateTime.Now;
            }
        }

        public string GetItemByIndex(int index)
        {
            if (index > this.GetSize() - 1)
                throw new Exception("GetItemByIndex: OutOfRange");

            int size = -1;
            foreach (string item in collection)
            {
                size++;
                if (size == index)
                    return item;
            }
            return "";
        }

        #region Overload

        public static MySet operator - (MySet set, string item)
        {
            set.collection.Remove(item);
            return set;
        }

        public static MySet operator * (MySet set, MySet set2)
        {
            set.collection.IntersectWith(set2.collection);
            return set;
        }

        public static bool operator <(MySet set, MySet set2)
        {
            return set.GetSize() < set2.GetSize();
        }

        public static bool operator >(MySet set, MySet set2)
        {
            if (set.collection.IsSubsetOf(set2.collection))
                return true;
            else
                return false;
        }

        public static MySet operator &(MySet set, MySet set2)
        {
            set.collection.Except(set2.collection);
            return set;
        }

        #endregion

    }
}
