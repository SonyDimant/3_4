using _3_4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4.Classes_and_others
{
    sealed class Massive2<T> : PapaArray<T>
    {
        private int b;
        private int c;

        private T[,] array;

        public Massive2(INewValues<T> values, bool inputt = false) : base(values, inputt) { }

        public override void RndInputt()
        {
            c = rnd.Next(1, 11);
            b = rnd.Next(1, 11);

            array = new T[b, c];

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    array[i, j] = newvalues.RandomValue();
                }
            }
        }
        public override void UserInputt()
        {
            Console.WriteLine("Длина строки");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Длина столбца");
            b = int.Parse(Console.ReadLine());

            array = new T[c, b];

            Console.WriteLine("Введите значения");

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = newvalues.IntValue();
                }
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void Snake_Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int j1 = i % 2 == 0
                        ? j
                        : array.GetLength(1) - 1 - j;

                    Console.Write(array[i, j1]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

