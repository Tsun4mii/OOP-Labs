using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MySet set = new MySet(1, "SYO");
            set.AddItem("Max");
            set.AddItem("Nick");

            MySet set2 = new MySet(2, "BEI");
            set2.AddItem("Max");
            set2.AddItem(" ");
            set2.AddItem("Lia");
            set2.AddItem("Nick");

            MySet set3 = new MySet(3, "LIO");
            set3.AddItem("Jio");
            set3.AddItem("Mari");

            MySet set4 = new MySet(4, "KPF");
            set4.AddItem("Jhon");
            set4.AddItem("");
            set4.AddItem("Leo");

            Console.WriteLine("--------- Перегрузка оператора - ---------");
            string name = "Jio";
            set3 = set3 - name;
            set3.Show();
            Console.WriteLine("--------- Перегрузка оператора * ------------");
            set2 = set2 * set;
            set2.Show();

            Console.WriteLine("--------- Перегрузка оператора & ----------------");
            set3 = set3 & set;
            set3.Show();

            Console.WriteLine("--------- Перегрузка оператора > ----------------");
            Console.WriteLine(set > set2);

            Console.WriteLine("--------- Перегрузка оператора < ----------------");
            Console.WriteLine(set < set2);

            Console.WriteLine("------------- Расширение Dif ----------------");
            int r = set2.Dif();
            Console.WriteLine(r);

            Console.WriteLine("---------------------------------------------");

            string abc = "awdg fseol  ajes";
            Console.WriteLine($"Count of words: {abc.CountOfWords()}");
            Console.WriteLine("---------------------------------------------");

            int r2 = set3.Sum();
            Console.WriteLine($"Sum lenght of all words: {r2}");
            Console.WriteLine("---------------------------------------------");
            set4.Show();
            set4.RemoveSpace();
            set4.Show();
            Console.WriteLine("---------------------------------------------");
            set4.CommaAfterWord();
            set4.Show();
        }
    }
}
