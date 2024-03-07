using System;
using _3_4.Interface;
using _3_4.Classes_and_others;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4.Classes_and_others
{
    abstract class PapaArray<T> : IPrinter, IPapaArray
    {
        protected StringNewValues sstring = new();
        protected BoolNewValues bbool = new();
        protected DoubleNewValues ddouble = new();

        protected INewValues<T> newvalues;

        protected static Random rnd = new Random();

        protected bool inputt = false;

        public PapaArray(INewValues<T> newvalues, bool inputt)
        {
            this.newvalues = newvalues;
            this.inputt = inputt;
            Fill();
        }

        public abstract void RndInputt();

        public abstract void UserInputt();

        public abstract void Print();

        public void Fill()
        {
            if (!inputt)
            {
                RndInputt();
            }
            else
            {
                UserInputt();
            }
        }
    }
}


