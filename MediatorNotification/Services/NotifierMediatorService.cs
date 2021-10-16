using MediatorNotification.Notifications;
using MediatorNotification.Services.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorNotification.Services
{
    public class NotifierMediatorService : INotifierMediatorService
    {
        private readonly IMediator _mediator;

        public NotifierMediatorService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task NotifyAsync(string notifyText, CancellationToken ct)
        {
            ct.ThrowIfCancellationRequested();

            await _mediator.Publish(new NotificationMessage { NotifyText = notifyText }, ct);
        }
    }
}
