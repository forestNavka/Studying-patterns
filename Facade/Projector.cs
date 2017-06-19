using System;

namespace Facade
{
    public class Projector : IProjector
    {
        public void Cool()
        {
            Console.WriteLine("The Projector is cooling now...");
        }

        public void PlugIn()
        {
            Console.WriteLine("The Projector is plugged in");
        }

        public void PlugOut()
        {
            Console.WriteLine("The Projector is plugged out");
        }

        public void Start()
        {
            Console.WriteLine("The Projector is started");
        }

        public void Stop()
        {
            Console.WriteLine("The Projector is stopped"); 
        }

        public void Warm()
        {
            Console.WriteLine("The Projector is warming now...");
        }
    }
}
