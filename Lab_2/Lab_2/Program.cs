using System;
using System.Linq;
using System.Text;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Типы 
            //а. Примитивные типы и ввод/вывод 
            bool b = true;
            byte bb = 255;
            sbyte sbb = 127;
            char ch = 'D';
            decimal dc = 3.2m;
            double db = 15.4;
            float fl = 3.4F;
            int icc;
            uint ui = 10U;
            long lg = 80L;
            ulong ulg = 80UL;
            short sh = 102;
            ushort ush = 1023;

            Console.WriteLine("Введите число целочисленного типа:");
            icc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"b = {b}, bb = {bb}, sbb = {sbb}, ch = {ch}, dc = {dc}"); //Интерполированное форматирование 
            Console.WriteLine("db = {0}, fl = {1}, i = {2}, ui = {3}, lg = {4}, ulg = {5}, sh = {6}, ush = {7}"
                , db, fl, icc, ui, lg, ulg, sh, ush); //Составное форматирование 

            //b. Явное и неявное преобразование 
            int num = 222;      //Неявное
            long lnum = num;

            char ch2 = 'W';     //Неявное
            int cnum = ch2;

            short sh2 = 353;    //Явное
            int int2 = (int)sh2;

            double dnum = 65.4; //Явное с использованием класса Convert
            int int3 = Convert.ToInt32(dnum);

            int int4 = 34;      //Явное
            char ch3 = (char)int4;

            //с. Упаковка 
            Object a = bb;
            byte bb2 = (byte)a;

            //d. Неявная типизация
            var fl2 = 4.3F;

            //e. Nullable
            int? int5 = null;
            Console.WriteLine(int5 == null);

            //f. 
            //var k = 4;
            //k = 3F;
            //Console.WriteLine($"{k}");

            //------------------------------------------------
            //Строки
            //а. 
            string str1 = "Hello";
            string str2 = "World";
            int res = String.Compare(str1, str2);
            if (res == 0)
                Console.WriteLine($"Строка {str1} = {str2}");
            else
                Console.WriteLine($"Строка {str1} != {str2}");

            //b. 
            String st1 = "Раз";
            String st2 = " Два";
            String st3;
            String st4 = "Три Четыре";

            Console.WriteLine(st1 + st2); //Сцепление
            st3 = st2;                    //Копирование
            Console.WriteLine(st2.Substring(1, 2)); //Подстрока
            string[] words = st4.Split(new char[] { ' ' });     //Разделение на слова 
            foreach (string s in words) Console.WriteLine(s);

            st1 = st1.Substring(0, 2) + str2 + st1.Remove(0, 2);
            Console.WriteLine(st1);
            st4 = st4.Remove(4, 6);

            //c.
            string st5 = "";
            string st6 = null;
            if (String.IsNullOrEmpty(st5))
                Console.WriteLine("Str5 пустая или null");
            else
                Console.WriteLine("не null или не пустая");


            if (String.IsNullOrEmpty(st6))
                Console.WriteLine("Str6 пустая или null\n");
            else
                Console.WriteLine("не null или не пустая\n");
            //d. 
            StringBuilder sb = new StringBuilder(" идет она");
            sb.Remove(6, 3);            
            sb.Insert(0, "Костя");      
            sb.Append("в школу");       
            Console.WriteLine(sb);
            //---------------------------------------------
            //Массивы
            //а.
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int ic = 0; ic < 3; ic++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(arr[ic, j] + " ");
                }
                Console.WriteLine();
            }

            //b.
            string[] strArr = { "Раз", "Два", "Три", "Четыре" };
            for(int i = 0; i < 4; i++)
                Console.Write(strArr[i] + " ");
            
            Console.WriteLine("Длинна массива строк: " + strArr.Length);

            string tmp = strArr[0];
            strArr[0] = strArr[3];
            strArr[3] = tmp;

            for (int i = 0; i < 4; i++)
                Console.Write(strArr[i] + " ");

            //с. 
            int[][] arrSt = new int[3][];
            arrSt[0] = new int[2];
            arrSt[1] = new int[3];
            arrSt[2] = new int[4];

            Console.WriteLine("\n");
            for (int i = 0; i < 2; ++i)
            {
                arrSt[0][i] = i + 3;
                Console.Write(arrSt[0][i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; ++i)
            {
                arrSt[1][i] = i + 8;
                Console.Write(arrSt[1][i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; ++i)
            {
                arrSt[2][i] = i + 2;
                Console.Write(arrSt[2][i] + "  ");
            }

            //d.
            var ntArr = new int[] { 1, 2, 3, 4 };
            var ntStr = "Не типизированная строка";
            Console.WriteLine("\n" + ntStr);

            //--------------------------------
            //Кортежи   
            //а.
            (int, string, char, string, ulong) crt = (18, "Юра", 'М', "Шуст", 193);
            Console.WriteLine("Возраст:   " + crt.Item1);
            Console.WriteLine("Имя:       " + crt.Item2);
            Console.WriteLine("Пол:       " + crt.Item3);
            Console.WriteLine("Фамилия:   " + crt.Item4);
            Console.WriteLine("Рост:      " + crt.Item5);

            //d.
            Console.WriteLine(crt.Item4 + " " + crt.Item2);

            //c.
            (var aa, var bb3) = (3, "3333");

            //d
            (int k, byte l) One = (3, 56);
            (long z, uint d) Two = (3, 56);
            Console.WriteLine(One == Two);

            //---------------------------------
            //5
            void function(int[] arr, string s) 
            {
                int max, min, sum;
                char frst;
                max = arr.Max<int>();
                min = arr.Min<int>();
                sum = arr.Sum();
                frst = s[0];
                var T = Tuple.Create(max, min, sum, frst);
                Console.WriteLine(T);
            }
            string strF = "World";
            int[] arrF = { 1, 2, 3, 4, 5 };
            function(arrF, strF);

            void f1()
            {
                checked
                {
                    int ai = 2147483647;
                    Console.WriteLine(ai + 1);
                }
            }
            void f2()
            {
                unchecked
                {
                    int ai2 = 2147483647;
                    Console.WriteLine(ai2 + 1);
                }
            }

            //f1();
            f2();
        }
    }
}
