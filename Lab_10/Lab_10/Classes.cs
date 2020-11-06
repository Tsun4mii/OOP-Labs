using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_10
{
    public class Plant : IComparable
    {
        protected int numOfPlants = 0;
        public override string ToString() => "Plant";
        public string color;
        public Plant(string Color) 
        {
            color = Color;
        }
        public virtual void Pour(int litters)
        {
            Console.WriteLine($"Вы полили растение {litters} литрами воды");
        }
        public void GetPlants() => Console.WriteLine($"Всего {numOfPlants} растеный вида {ToString()}");

        public int CompareTo(object obj)
        {
            return color.CompareTo(obj);
        }
    }

    public class OwnCollection
    {
        public HashSet<Plant> Plants;

        public OwnCollection()
        {
            Plants = new HashSet<Plant>();
        }

        public void Delete(Plant item)
        {
            Plants.Remove(item);
        }
        public void Add(Plant item)
        {
            Plants.Add(item);
        }
    }
}
