using MediatR;

namespace MediatorNotification.Notifications
{
    public class NotificationMessage : INotification
    {
        public string NotifyText { get; set; }
    }
}
