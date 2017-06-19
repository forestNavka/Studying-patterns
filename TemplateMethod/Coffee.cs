using System;

namespace TemplateMethod
{
    public class Coffee : CoffeinBeverage
    {
        protected sealed override void MakeBeverage()
        {
            Console.WriteLine("Making Coffee");
        }

        protected sealed override void AddCondiments()
        {
            Console.WriteLine("Adding Milk");
        }
    }
}
