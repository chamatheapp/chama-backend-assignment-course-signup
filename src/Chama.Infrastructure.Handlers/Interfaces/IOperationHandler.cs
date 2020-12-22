using System.Threading.Tasks;
using Chama.Infrastructure.Messaging.Interfaces;

namespace Chama.Infrastructure.Handlers.Interfaces
{
    public interface IOperationHandler<in TX, TY>
        where TX : IOperationRequest
        where TY : IOperationResponse
    {
        Task<TY> Handle(TX request);
    }
}