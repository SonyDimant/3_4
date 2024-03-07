using System;
using _3_4.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_4.Classes_and_others;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter[] printer_array = new IPrinter[7];

            IntNewValues iint = new();
            StringNewValues sstring = new();
            BoolNewValues bbool = new();
            DoubleNewValues ddouble = new();

            Console.WriteLine("Выберите способ ввода: false - случайно, true - вручную");
            bool inputt = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Порядок: int, string, double, bool");

            Massive_1<int> intmassive1 = new(iint, inputt);
            printer_array[0] = intmassive1;
            Massive_1<string> stringmassive1 = new(sstring, inputt);
            printer_array[1] = stringmassive1;
            Massive_1<double> doublemassive1 = new(ddouble, inputt);
            printer_array[2] = doublemassive1;
            Massive_1<bool> boolmassive1 = new(bbool, inputt);
            printer_array[3] = boolmassive1;

            Console.WriteLine();

            Massive2<int> intmassive2 = new(iint, inputt);
            printer_array[4] = intmassive2;
            Massive2<string> stringmassive2 = new(sstring, inputt);
            printer_array[5] = stringmassive2;
            Massive2<double> doublemassive2 = new(ddouble, inputt);
            printer_array[6] = doublemassive2;
            Massive2<bool> boolmassive2 = new(bbool, inputt);
            printer_array[7] = boolmassive2;

            Console.WriteLine();


            for (int i = 0; i < printer_array.Length; i++)
            {
                Console.WriteLine($"Массив {printer_array[i].GetType()}:");

                printer_array[i].Print();
                Console.WriteLine();
            }
        }
    }
}
