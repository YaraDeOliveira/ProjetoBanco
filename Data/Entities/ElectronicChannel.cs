using System.Collections.Generic;

namespace ProjetoFinal.Data.Entities
{
    public class ElectronicChannel
    {
        public Identification Identification { get; set; }  
        public IEnumerable<Service> Services { get; set; }
    }
}