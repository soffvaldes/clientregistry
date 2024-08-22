using ClientRegistry.DTOs.ClientRegistry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRegistrey.BusinessObjects.Backend.Interfaces.CreateClient
{
    public interface ICreateClientInputPort
    {
        Task Handle(ClientRegistryDto clientRegistry);
    }
}
