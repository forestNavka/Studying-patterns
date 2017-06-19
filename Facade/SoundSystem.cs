using System;

namespace Facade
{
    public class SoundSystem : ISoundSystem

    {
        public void Off()
        {
            Console.WriteLine("The Sound System is switched off");
        }

        public void On()
        {
            Console.WriteLine("The Sound System is switched on");
        }

        public void PlugIn()
        {
            Console.WriteLine("The Sound System is plugged in");
        }

        public void PlugOut()
        {
            Console.WriteLine("The Sound System is plugged out");
        }
    }
}
