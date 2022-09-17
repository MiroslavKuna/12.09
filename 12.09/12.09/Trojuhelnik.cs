using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _12._09
{
    internal class Trojuhelnik
    {
        private int a;
        private int b;
        private int c;

        public Trojuhelnik(int a, int b, int c)
        {
            if (a + b > c && b + c > a && c + a > b)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                Console.WriteLine("Triangle inequality does not apply");
            }
        }

        public bool Rovnostranny() 
        {
            if (this.A == this.B && this.B == this.C && this.C == this.A) 
            {
                return true;
            }
            return false;
        }
        public bool Rovnoramenny()
        {
            if (this.A == this.B && this.B != this.C || 
                this.B == this.C && this.B != this.A || 
                this.C == this.A && this.A != this.B)
            {
                return true;
            }
            return false;
        }
        public bool Pravouhly()
        {
            if (Math.Pow(this.C, 2) == Math.Pow(this.A, 2) + Math.Pow(this.B, 2) ||
                Math.Pow(this.A, 2) == Math.Pow(this.C, 2) + Math.Pow(this.B, 2) ||
                Math.Pow(this.B, 2) == Math.Pow(this.A, 2) + Math.Pow(this.C, 2))
            {
                return true;
            }
            return false;
        }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
    }
}
