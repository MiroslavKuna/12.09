namespace _12._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERVAL");
            Interval a = new Interval(5, 6);
            Console.WriteLine(a);
            Interval b = new Interval(9, 12);
            Console.WriteLine(b+"\n");

            a.Edit(6, 3);
            a.Edit(3, 11);
            Console.WriteLine(a);
            Console.WriteLine(a.inBounds(4));
            Console.WriteLine(a.inBounds(12)+ "\n");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a.Merge(b) + "\n \n");


            Console.WriteLine("PRIMKA");
            Primka p = new Primka(4, 9);
            Console.WriteLine(p);
            Console.WriteLine("length = " + p.Length()+ "\n \n");


            Console.WriteLine("TROJUHELNIK");
            Trojuhelnik t = new Trojuhelnik(5, 12, 81);

            Trojuhelnik rs = new Trojuhelnik(5, 5, 5);
            Console.WriteLine(rs.Rovnostranny());
            Console.WriteLine(rs.Rovnoramenny());
            Console.WriteLine(rs.Pravouhly()+"\n");

            Trojuhelnik rr = new Trojuhelnik(5, 5, 8);
            Console.WriteLine(rr.Rovnostranny());
            Console.WriteLine(rr.Rovnoramenny());
            Console.WriteLine(rr.Pravouhly() + "\n");

            Trojuhelnik pr = new Trojuhelnik(3, 4, 5);
            Console.WriteLine(pr.Rovnostranny());
            Console.WriteLine(pr.Rovnoramenny());
            Console.WriteLine(pr.Pravouhly() + "\n \n");


            Console.WriteLine("POTRAVINA");
            Potravina chips = new Potravina("Potato chips", 100, 561);
            Console.WriteLine(chips);
            chips.Edit("potat chip", 101, 562);
            Console.WriteLine(chips);
            Console.WriteLine(chips.Transfer()+"kJ");
            Console.WriteLine("Percentage of your daily caloric income is "+chips.Percent("muz", 17, 187, 92) + "%");

        }

    }
}