using System.Threading.Tasks;
using Chama.Infrastructure.Messaging.Interfaces;

namespace Chama.Infrastructure.Handlers.Interfaces
{
    public interface IEventHandler<in T> where T: IEvent
    {
        Task Handle(T @event);        
    }
}