using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._09
{
    internal class Primka
    {
        private int start;
        private int end;

        public int Start { get => start; set => start = value; }
        public int End { get => end; set => end = value; }

        public Primka(int start, int end)
        {
            if (start <= end)
            {
                Start = start;
                End = end;
            }
            else { Console.WriteLine("Start can't be further than the end"); }
        }
        public void Edit(int start, int end)
        {
            if (start <= end)
            {
                Start = start;
                End = end;
            }
            else { Console.WriteLine("Start can't be further than the end"); }

        }

        public int Length() 
        {
            int length = this.End - this.Start;
            return length; 
        }

        public override string ToString()
        {
            return "|"+start+", "+end+"|";
        }
    }
}
