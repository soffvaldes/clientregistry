using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRegistry.DTOs.ClientRegistry
{
    public class ClientRegistryDto (string firstName, string lastName, DateTime dateofBirth,
        string address, string phoneNumber, string email,
        string documentNumber )
    {
        public string FirstName => firstName;
        public string LastName => lastName;
        public DateTime DateOfBirth => dateofBirth;
        public string Address => address;
        public string PhoneNumber => phoneNumber;
        public string Email => email;
        public string DocumentNumber => documentNumber;
    }
}
