using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    partial class Customer
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Customer b = obj as Customer;
            if (b == null)
                return false;
            return this.Name == b.Name && this.Surname == b.Surname && this.FatherName == b.FatherName &&
            this.balance == b.balance && this.CardNumber == b.CardNumber;
        }

        public override int GetHashCode()
        {
            return (CardNumber * 2) / 3;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Fathername: {FatherName}"; ;
        }
    }
}
