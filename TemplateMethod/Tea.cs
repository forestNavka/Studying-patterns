using System;

namespace TemplateMethod
{
    public class Tea : CoffeinBeverage
    {
        protected sealed  override void MakeBeverage()
        {
            Console.WriteLine("Making Tea");
        }

        protected sealed override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
