using CleanArch.Domain.Core.Events;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
