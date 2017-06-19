using System;

namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);

            var invoker = new RemoteControl();
            invoker.SetCommand(lightOnCommand);
            invoker.SetCommand(lightOffCommand);

            invoker.Invoke();
            invoker.Undo();
            Console.ReadLine();
        }
    }
}
