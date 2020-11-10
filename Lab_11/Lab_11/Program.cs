using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Authentication;

namespace Lab_11
{
    class CustomerComparer : IComparer<Customer>
    {
        int IComparer<Customer>.Compare(Customer x, Customer y)
        {
            if (x.Name[0] > y.Name[0])
                return 1;
            else if (x.Name[0] < y.Name[0])
                return -1;
            else
                return 0;
        }
    }

    class Sells
    {
        public string Surname { get; set; }
        public string Item { get; set; }
        public string Country { get; set; }

        public Sells(string surname = "", string item = "", string country = "")
        {
            Surname = surname;
            Item = item;
            Country = country;
        }
    }

    class Program
    {

        static void Main()
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            var selectedMonthN = from m in month
                                 where m.Length == 7
                                 select m;
            Console.WriteLine("Месяцы длинной 7:");
            foreach (string str in selectedMonthN)
                Console.Write(str + ",  ");


            var selectedMonthWinSum = from m in month
                                      where Array.IndexOf(month, m) < 2 ||
                                      Array.IndexOf(month, m) > 4 && Array.IndexOf(month, m) < 8 ||
                                      Array.IndexOf(month, m) == 11
                                      select m;
            Console.WriteLine("\n\nЗимние и летние месяцы:");
            foreach (string str in selectedMonthWinSum)
                Console.Write(str + ",  ");


            var selectedMonthAlfa = from m in month
                                    orderby m
                                    select m;
            Console.WriteLine("\n\nМесяцы по алфавиту:");
            foreach (string str in selectedMonthAlfa)
                Console.Write(str + ",  ");


            var selectedMonthU4 = from m in month
                                  where m.Contains('u') && m.Length > 3
                                  select m;
            Console.WriteLine("\n\nМесяцы с буквой 'u', длина >= 4:");
            foreach (string str in selectedMonthU4)
                Console.Write(str + ",  ");



            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Yuri", "Shust", "Oligovich", 1234, 10000));
            customers.Add(new Customer("Petr", "Hart", "Nikolaev", 654, 14323));
            customers.Add(new Customer("Jhordany", "-----", "Yovanovich", 1111, 123125));
            customers.Add(new Customer("Euheni", "Basko", "Igorevich", 34, 2324));
            customers.Add(new Customer("Jhordany2", "-----", "Yovanovich2", 1011, 123125));

            var SortedByName = from c in customers
                               orderby c.Name
                               select c;
            Console.WriteLine();
            Console.WriteLine("Список покупателей в алфавитном порядке: ");
            foreach (Customer c in SortedByName)
                Console.Write(c.Name + " ");

            var intervalCard = from c in customers
                               where (c.CardNumber > 600 && c.CardNumber < 1200)
                               select c;
            Console.WriteLine();
            Console.WriteLine("Список покупателей с картой в интервале от 600 до 1200: ");
            foreach (Customer c in intervalCard)
                Console.Write(c.Name + " - " + c.CardNumber + " ");

            var maxCash = customers.Max(c => c.Balance);
            Console.WriteLine();
            Console.WriteLine(maxCash);

            var lastRes = (from c in customers
                           where c.Balance == maxCash
                           select c).Take(2);

            foreach (Customer c in lastRes)
                Console.Write(c.Name + " ");

            List<Sells> sells = new List<Sells>();
            sells.Add(new Sells("Shust", "Ryzen7", "Belarus"));
            sells.Add(new Sells("Hart", "Traktor", "Russia"));
            sells.Add(new Sells("Basko", "Hoodie", "Belarus"));

            var res = from c in customers
                      join s in sells on c.Surname equals s.Surname
                      select new { Name = c.Name, Surname = c.Surname, Item = s.Item };

            Console.WriteLine();
            foreach (var item in res)
                Console.WriteLine($"{item.Name}  {item.Surname} - {item.Item}");

            List<int> nums = new List<int>() { 1, 54, 42, 12, 23, 64, 37 };
            var res2 = nums.OrderBy(i => i).Take(4).Skip(1).Where(i => i >20).Aggregate((x,y) => x + y);
           
                Console.WriteLine(res2);
        }
    }
}
