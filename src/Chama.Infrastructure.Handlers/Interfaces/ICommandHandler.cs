using System.Threading.Tasks;
using Chama.Infrastructure.Messaging.Interfaces;

namespace Chama.Infrastructure.Handlers.Interfaces
{
    public interface ICommandHandler<in T> where T: ICommand
    {
        Task Handle(T command);
    }
}