using System;
using System.Collections.Generic;

namespace Lab_3
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

    class Program
    {

        static void Main()
        {
            Customer a = new Customer("Yuri", "Shust", "Olegovich", 137, 19000);
            a.PrintInfo();
            a.AddToCard(1000);
            a.PrintInfo();
            a.MinusFromCard(2000);
            a.PrintInfo();
            Customer.TypeOfClass();
            Customer b = new Customer("Jhordany", "-----", "Yovanovich", 1111, 100000);
            Customer c = new Customer(a);
            Console.WriteLine("---------------------------------");
            if (a.Equals(b))
            {
                Console.WriteLine("Запись 1 = записи 2");
            }
            else
                Console.WriteLine("Запись 1 != записи 2");

            if (a.Equals(c))
            {
                Console.WriteLine("Запись 1 = записи 3");
            }
            else
                Console.WriteLine("Запись 1 != записи 3");
            Console.WriteLine("---------------------------------");

            Customer[] arrCust = new Customer[3];
            arrCust[0] = new Customer(a);
            arrCust[1] = new Customer(b);
            arrCust[2] = new Customer("Petr", "Hart", "Nikolaev", 654, 1000);

            Array.Sort(arrCust, new CustomerComparer());

            foreach (Customer element in arrCust)
            {
                element.PrintInfo();
            }
            Console.WriteLine("---------------------------------");

            int bufPointLow, bufPointCup;
            Console.WriteLine("Введите нижнюю границу диапазона");
            bufPointLow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу диапазона");
            bufPointCup = Convert.ToInt32(Console.ReadLine());

            foreach (Customer element in arrCust)
            {
                if (element.CardNumber >= bufPointLow && element.CardNumber <= bufPointCup)
                    element.PrintInfo();
            }


            Console.WriteLine("---------------------------------");
            var User = new { Name = "Oleg", Age = 30 };
            Console.WriteLine(User.Name + " " + User.Age);
        }
    }
}
