using System;

namespace parovoziktytyty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Train train = new Train();
            Console.WriteLine(train.search_site(11).ToString());
            Console.WriteLine(train.search_site(36).ToString());
            Console.WriteLine(train.search_site(50).ToString());
            Console.WriteLine(train.search_site(70).ToString());
            Console.WriteLine(train.search_site(0).ToString());
        }
    }
}
