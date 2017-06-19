using System.Collections.Generic;

namespace Command
{
    public class RemoteControl
    {
        private readonly Queue<ICommand> _queuedCommands = new Queue<ICommand>();
        private readonly Stack<ICommand> _executedCommands = new Stack<ICommand>();

        public void SetCommand(ICommand command)
        {
            _queuedCommands.Enqueue(command);
        }

        public void Invoke()
        {
            while (_queuedCommands.Count > 0)
            {
                var command = _queuedCommands.Dequeue();
                command.Execute();
                _executedCommands.Push(command);
            }
        }

        public void Undo()
        {
            while (_executedCommands.Count > 0)
            {
                var command = _executedCommands.Pop();
                command.Undo();
            }
        }
    }
}
