using _3_4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4.Classes_and_others
{
    class BoolNewValues :INewValues<bool>
    {
        Random rnd = new Random();
        public bool IntValue()
        {
            return bool.Parse(Console.ReadLine());
        }
        public bool RandomValue()
        {
            bool[] bbool = { true, false };
            return bbool[rnd.Next(bbool.Length)];
        }

        
    }
}
