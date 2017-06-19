using System;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDisplay display = new Display();
            ISoundSystem soundSystem  = new SoundSystem();
            IProjector projector = new Projector();

            IHomeTheatre homeTheatre = new HomeTheatreFacade(display, projector, soundSystem);

            homeTheatre.On();
            Console.WriteLine("Watching .......................");
            homeTheatre.Off();

            Console.ReadLine();
        }
    }
}
