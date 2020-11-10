using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    partial class Customer
    {
        public readonly int id;
        static int numberOfCustomers = 0;
        const int a = 43;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public int CardNumber;
        private int balance;
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > -1000 && value < 100000000)
                    balance = value;
            }
        }

        public Customer(string name = "", string surname = "", string fathername = "", int cardnumber = 0, int balance = 0)
        {
            ++numberOfCustomers;
            Name = name;
            Surname = surname;
            FatherName = fathername;
            CardNumber = cardnumber;
            Balance = balance;
            id = this.GetHashCode();
        }

        public Customer(Customer a)
        {
            ++numberOfCustomers;
            Name = a.Name;
            Surname = a.Surname;
            FatherName = a.FatherName;
            CardNumber = a.CardNumber;
            Balance = a.Balance;
            id = this.GetHashCode();
        }

        private Customer()
        {
            numberOfCustomers++;
            Console.WriteLine("Будущая запись");
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("ФИО: " + Name + " " + Surname + " " + FatherName);
            Console.WriteLine("Номер карты: " + CardNumber);
            Console.WriteLine("Баланс: " + balance + "$");
            Console.WriteLine("ID: " + id);
        }

        public static void TypeOfClass()
        {
            Type tp = Type.GetType("Lab_3.Customer");
            Console.WriteLine(tp.AssemblyQualifiedName);
        }

        public void AddToCard(int b)
        {
            Balance = Balance + b;
        }

        public void MinusFromCard(int b)
        {
            Balance = Balance - b;
        }
    }
}
