namespace _12._09
{
    internal class Program
    {
        static void Main(string[] args)
        {

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




        }

    }
}