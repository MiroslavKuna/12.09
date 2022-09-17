using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._09
{
    internal class Potravina
    {
        private string name;
        private int weight;
        private int kcal;


        public Potravina(string name, int weight, int kcal)
        {
            this.name = name;
            this.weight = weight;
            this.kcal = kcal;
        }

        public void Edit(string name, int weight, int kcal)
        {
            this.name = name;
            this.weight = weight;
            this.kcal = kcal;
        }

        public int Kcal { get => kcal; set => kcal = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Name { get => name; set => name = value; }

        public double Transfer() 
        {
            double kj = kcal* 4.185;
            return kj;
        }

        public double Percent(string sex, int age, int weight, int height) 
        {
            double brm;
            double percentage;
            if (sex.Equals("zena"))
            {
                brm = 655.0955 + (9.5634 * weight) + (1.8496 * height) - (4.6756 * age);
                percentage = this.Kcal * 100 / brm;
                return percentage;
            }
            else if (sex.Equals("muz"))
            {
                brm = 66.473 + (13.7516 * weight) + (5.0033 * height) - (6.755 * age);
                percentage = this.Kcal * 100 / brm;
                return percentage;
            }
            else 
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return name + ", weight: "+ weight + "g, energy value: "+kcal+ "kcal";
        }
    }
}
