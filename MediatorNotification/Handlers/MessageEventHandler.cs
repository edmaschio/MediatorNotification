using MediatorNotification.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorNotification.Handlers
{
    public class MessageEventHandler : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken ct)
        {
            ct.ThrowIfCancellationRequested();
            return Task.Run(() =>
            {
                Console.WriteLine($"Message: {notification.NotifyText}");
            }, ct);
        }
    }
}
