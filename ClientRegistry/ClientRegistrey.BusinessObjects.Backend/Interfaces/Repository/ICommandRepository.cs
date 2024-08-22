using ClienRegistry.Entities.Backend.Interface;
using ClienRegistry.Entities.Backend.POCOEntities;

namespace ClientRegistrey.BusinessObjects.Backend.Interfaces.Repository
{
    public interface ICommandRepository : IUnitOfWork
    {
        Task CreateClient(Client client);
    }
}
