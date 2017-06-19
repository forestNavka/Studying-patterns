using System;

namespace TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeinBeverage coffee = new Coffee();
            coffee.Prepare();

            CoffeinBeverage tea = new Tea();
            tea.Prepare();

            Console.ReadLine();
        }
    }
}
