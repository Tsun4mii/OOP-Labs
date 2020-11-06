using Lab_10;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Lab_5
{
    class Program
    {

        static void Main(string[] args)
        {

            Plant plant1 = new Plant("Red");
            Plant plant2 = new Plant("Green");
            Plant plant3 = new Plant("Blue");
            OwnCollection own = new OwnCollection();
            own.Add(plant1);
            own.Add(plant2);
            own.Add(plant3);
            Console.WriteLine("Вывод: ");
            foreach (Plant item in own.Plants)
            {
                Console.WriteLine(item.color);
            }
            own.Delete(plant1);
            Console.WriteLine("Вывод: после удаления");
            foreach (Plant item in own.Plants)
            {
                Console.WriteLine(item.color);
            }
            //-------------------------------------------
            HashSet<int> Set = new HashSet<int>();
            for (int i = 0; i < 10; i++)
                Set.Add(i);
            Console.WriteLine("Вывод сета: ");
            foreach (int item in Set)
            {
                Console.Write(item + " ");
            }
            for (int i = 3; i < 5; i++)
                Set.Remove(i);
            Console.WriteLine();
            Console.WriteLine("Вывод сета после удаления 2 элементов: ");
            foreach (int item in Set)
            {
                Console.Write(item + " ");
            }
            int[] a1 = new int[Set.Count()];
            a1 = Set.ToArray();
            Stack<int> Stack1 = new Stack<int>();
            for (int i = 0; i < Set.Count(); i++)
                Stack1.Push(a1[i]);
            Console.WriteLine();
            Console.WriteLine("Вывод стека с элементами из сета: ");
            foreach (object i in Stack1)
                Console.Write(i + " ");
            Console.WriteLine();


            ObservableCollection<Plant> Col = new ObservableCollection<Plant>();
            Col.CollectionChanged += Obs_CollectionChanged;
            Col.Add(plant1);
            Col.Add(new Plant("Blue"));
            Col.Remove(plant1);
            foreach (Plant item in Col)
            {
                Console.WriteLine(item.color);
            }
        }
        private static void Obs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Элемент добавлен ");
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Элемент удален ");
            }
            else
            {
                Console.WriteLine("Нет добавленных/удаленных элементов");
            }
        }
    }
}
