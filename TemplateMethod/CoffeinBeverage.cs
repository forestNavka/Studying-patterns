using System;

namespace TemplateMethod
{
    public abstract class CoffeinBeverage
    {
        public void Prepare()
        {
            BoilWater();
            MakeBeverage();
            FillTheCup();
            AddCondiments();
        }

        protected abstract void MakeBeverage();

        protected virtual void AddCondiments() {}

        private void BoilWater()
        {
            Console.WriteLine("Boiling water ...");
        }

        private void FillTheCup()
        {
            Console.WriteLine("Filling cup ...");
        }
    }
}
