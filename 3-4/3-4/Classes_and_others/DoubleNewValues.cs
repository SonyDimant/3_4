using System;
using _3_4.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4.Classes_and_others
{
    class DoubleNewValues : INewValues<double>
    {
        Random rnd = new Random();
        public double IntValue()
        {
            return double.Parse(Console.ReadLine());
        }
        public double RandomValue()
        {
            return rnd.NextDouble();
        }

        
    }
}

