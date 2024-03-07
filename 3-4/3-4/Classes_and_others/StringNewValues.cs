using System;
using _3_4.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4.Classes_and_others
{
    class StringNewValues: INewValues<string>
    {
        Random rnd = new();
        public string RandomValue()
        {
            string alph = "qwertyuiopasdfghjklzxcvbnm1234567890";
            string x = "";
            for (int i = 0; i < rnd.Next(10); i++)
            {
                x += alph[rnd.Next(alph.Length)];
            }
            return x;
        }

        public string IntValue()
        {
            return Console.ReadLine();
        }
    }
}
