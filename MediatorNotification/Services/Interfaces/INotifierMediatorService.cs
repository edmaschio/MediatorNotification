using System.Threading;
using System.Threading.Tasks;

namespace MediatorNotification.Services.Interfaces
{
    public interface INotifierMediatorService
    {
        Task NotifyAsync(string notifyText, CancellationToken ct);
    }
}
