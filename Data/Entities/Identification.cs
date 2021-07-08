using System.Collections.Generic;

namespace ProjetoFinal.Data.Entities
{
    public class Identification
    {
        public string Type { get; set; }    
        public string AdditionalInfo { get; set; }
        public IEnumerable<string> Urls { get; set; }
        
    }
}