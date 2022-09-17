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

        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }

        public bool Edit(int min, int max)
        {
            if (min > max)
            {
                Console.WriteLine("Wrongly inputed interval");
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
        public Interval? Merge(Interval b)
        {
            if (this.Min > b.Min && this.Max < b.Max)
            {
                return this;
            }
            else if (this.Min < b.Min && this.Max > b.Max)
            {
                return b;
            }
            else if (this.Max < b.Min && this.Max < b.Max || b.Max < this.Min && b.Max < this.Max)
            {
                return null;
            }
            else 
            {
                if (this.Min < b.Min)
                {
                    return new Interval(b.Min, this.Max);
                }
                else 
                {
                    return new Interval(this.Min, b.Max);
                }
            }
        }

        public override string ToString()
        {
            return "["+Min+", "+Max+"]";
        }
    }
}
