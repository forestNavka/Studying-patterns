using System;

namespace Singlton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s1 = Singlton.Instance;
            var s2 = Singlton.Instance;
            Console.WriteLine(s1 == s2);
            Console.ReadLine();
        }
    }
}
