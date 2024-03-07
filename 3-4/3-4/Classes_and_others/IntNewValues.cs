using System;
using _3_4.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4.Classes_and_others
{
    class IntNewValues : INewValues<int>
    {
        Random rnd = new Random();
        public int RandomValue()
        {
            return rnd.Next(100);
        }

        public int IntValue()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
