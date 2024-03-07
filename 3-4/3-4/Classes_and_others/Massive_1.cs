using _3_4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4.Classes_and_others
{
    sealed class Massive_1<T> : PapaArray<T>
    {
        private T[] array;
        private int n;
        public int Length
        {
            get { return n; }
        }
        public Massive_1(INewValues<T> newvalues, bool inputt = false) : base(newvalues, inputt) { }

        public override void RndInputt()
        {
            n = rnd.Next(1, 11);

            array = new T[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = newvalues.RandomValue();
            }
        }

        public override void UserInputt()
        {
            Console.WriteLine("Длина массива");
            n = int.Parse(Console.ReadLine());

            array = new T[n];

            Console.WriteLine("Введите значения");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newvalues.IntValue();
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine(String.Join(" ", array));
        }


    }
}
