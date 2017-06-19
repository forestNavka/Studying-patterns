using System;

namespace Command
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is turned on");
        }

        public void Off()
        {
            Console.WriteLine("Light is turned off");
        }
    }
}