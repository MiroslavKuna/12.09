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
            Min = min;
            Max = max;
        }

        public int Max { get => max; set => max = value; }
        public int Min { get => min; set => min = value; }

        public bool Edit(int min, int max)
        {
            if (min > max)
            {
                return false;
            }
            this.min = min;
            this.max = max;
            return true;
        }

        public bool inBounds(int num)
        {
            if (num > min && num < max) {
                return true;
            }
            return false;
        }
        public static Interval? Merge(Interval a, Interval b)
        {
            if (a.Min > b.Min && a.Max < b.Max)
            {
                return a;
            }
            else if (a.Min < b.Min && a.Max > b.Max)
            {
                return b;
            }
            else if (a.Max < b.Min && a.Max < b.Max || b.Max < a.Min && b.Max < a.Max)
            {
                return null;
            }
            else 
            {
                if (a.Min < b.Min) 
                {
                    
                }
                
            }
        }
    }
}
