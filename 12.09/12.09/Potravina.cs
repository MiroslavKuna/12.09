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
            if (name.Equals("") || weight <= 0 || kcal <= 0)
            {
                Console.WriteLine("Misinput");
            }
            else 
            {
                Name = name;
                Weight = weight;
                Kcal = kcal;
            }
        }

        public void Edit(string name, int weight, int kcal)
        {
            if (name.Equals("") || weight <= 0 || kcal <= 0)
            {
                Console.WriteLine("Misinput");
            }
            else
            {
                Name = name;
                Weight = weight;
                Kcal = kcal;
            }
        }

        public int Kcal { get => kcal; set => kcal = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Name { get => name; set => name = value; }

        public string Transfer() 
        {
            double kj = Kcal * 4.185;
            return Kcal+ "=" + kj;
        }

        public double Percent(string sex, int age, int weight, int height) 
        {
            double brm;
            double percentage;
            if (sex.Equals("zena"))
            {
                brm = 655.0955 + (9.5634 * weight) + (1.8496 * height) - (4.6756 * age);
                percentage = Kcal * 100 / brm;
                return percentage;
            }
            else if (sex.Equals("muz"))
            {
                brm = 66.473 + (13.7516 * weight) + (5.0033 * height) - (6.755 * age);
                percentage = Kcal * 100 / brm;
                return percentage;
            }
            else 
            {
                Console.WriteLine("Sex Misinputed");
                return 0;
            }
        }
        public override string ToString()
        {
            return Name + ", weight: "+ Weight + "g, energy value: "+ Kcal + "kcal";
        }
    }
}
