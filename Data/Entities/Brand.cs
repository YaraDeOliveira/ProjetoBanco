using System.Collections.Generic;

namespace ProjetoFinal.Data.Entities
{
    public class Brand
    {
        public string Name { get; set; }    
        public IEnumerable<Company> Companies { get; set; } 
        
    }
}