using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._09
{
    internal class Interval
    {
        private int min;
        private int max;

        public Interval(int min, int max)
        {
            if (min <= max)
            {
                Min = min;
                Max = max;
            }
            else
            {
                Console.WriteLine("The interval minimum can't be bigger than the maximum");
            }

        }

        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }

        public bool Edit(int min, int max)
        {
            if (min > max)
            {
                Console.WriteLine("Wrongly inputed interval");
                return false;
            }
            Min = min;
            Max = max;
            return true;
        }

        public bool inBounds(int num)
        {
            if (num > min && num < max) {
                return true;
            }
            return false;
        }
        public Interval? Merge(Interval b)
        {
            if (Min > b.Min && Max < b.Max)
            {
                return this;
            }
            else if (Min < b.Min && Max > b.Max)
            {
                return b;
            }
            else if (Max < b.Min && Max < b.Max || b.Max < Min && b.Max < Max)
            {
                return null;
            }
            else 
            {
                if (Min < b.Min)
                {
                    return new Interval(b.Min, Max);
                }
                else 
                {
                    return new Interval(Min, b.Max);
                }
            }
        }

        public override string ToString()
        {
            return "["+Min+", "+Max+"]";
        }
    }
}
