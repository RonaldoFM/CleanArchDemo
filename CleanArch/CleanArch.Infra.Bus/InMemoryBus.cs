using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task SendCommand<T>(T command) where T : Command
        {
            await _mediator.Send(command);
        }
        /*public async Task PublishEvent<T>(T @event) where T : Event
        {
            await _mediator.Publish(@event);
        }*/
    }
}
