using ClienRegistry.Entities.Backend.POCOEntities;
using ClientRegistrey.BusinessObjects.Backend.Interfaces.CreateClient;
using ClientRegistrey.BusinessObjects.Backend.Interfaces.Repository;
using ClientRegistry.DTOs.ClientRegistry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRegistrey.BusinessObjects.Backend
{
    public class CreateClientInteractor : ICreateClientInputPort
    {
        private readonly ICommandRepository _repository;
        private readonly ICreateClientOutpuPort _presenter;

        public CreateClientInteractor(ICommandRepository repository, ICreateClientOutpuPort presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(ClientRegistryDto clientRegistry)
        {
            var client = ToDto(clientRegistry);
            await _repository.CreateClient(client);
            await _repository.SaveChangesAsync();
            var clientDTO = ToEntity(client);
            await _presenter.Handle(clientDTO);
        }

        /// <summary>
        /// pasa de DTO a Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private static ClientRegistryDto ToEntity(Client entity)
        {
            return new ClientRegistryDto(
                entity.Firstname,
                entity.Lastname,
                entity.Dateofbirth,
                entity.Address,
                entity.Phonenumber,
                entity.Email, entity.Documentnumber);
        }


        /// <summary>
        /// este método recibe como parámetro un ClientRegistryDto y lo convierte en una entidad POCO 
        /// del tipo client 
        /// </summary>
        /// <param name="createClient"> DTO que contiene los datos a enviar al almacen de datos</param>
        /// <returns>devuelve entidad POCO que cotiene los datos agregados al almacen de datos
        /// icluidos su ID</returns>
        private static Client ToDto(ClientRegistryDto createClient)
        {
            return new Client
            {
                Firstname = createClient.FirstName,
                Lastname = createClient.LastName,
                Dateofbirth = createClient.DateOfBirth,
                Address = createClient.Address,
                Email = createClient.Email,
                Phonenumber = createClient.PhoneNumber,
                Documentnumber = createClient.DocumentNumber
            };
        }


    }
}
