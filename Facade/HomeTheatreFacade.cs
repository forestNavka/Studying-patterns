namespace Facade
{
    public class HomeTheatreFacade : IHomeTheatre
    {
        private readonly IDisplay _display;
        private readonly IProjector _projector;
        private readonly ISoundSystem _soundSystem;

        public HomeTheatreFacade(IDisplay display, IProjector projector, ISoundSystem soundSystem)
        {
            _display = display;
            _projector = projector;
            _soundSystem = soundSystem;
        }
        public void Off()
        {
            _display.Off();
            _display.PlugOut();

            _soundSystem.Off();
            _soundSystem.PlugOut();

            _projector.Stop();
            _projector.Cool();
            _projector.PlugOut();
        }

        public void On()
        {
            _display.PlugIn();
            _display.On();

            _soundSystem.PlugIn();
            _soundSystem.On();

            _projector.PlugIn();
            _projector.Warm();
            _projector.Start();
        }
    }
}
