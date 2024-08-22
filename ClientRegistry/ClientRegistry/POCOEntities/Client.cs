using ClientRegistry.DTOs.ClientRegistry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienRegistry.Entities.Backend.POCOEntities;

public class Client
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime Dateofbirth { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phonenumber { get; set; }
    public string Documentnumber { get; set; }
  
}
