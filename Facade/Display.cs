using System;

namespace Facade
{
    public class Display : IDisplay
    {
        public void Off()
        {
            Console.WriteLine("The Display is switched off");
        }

        public void On()
        {
            Console.WriteLine("The Display is switched on");
        }

        public void PlugIn()
        {
            Console.WriteLine("The Display is plugged in");
        }

        public void PlugOut()
        {
            Console.WriteLine("The Display is plugged out");
        }
    }
}
