namespace ProjetoFinal.Data.Entities
{
    public class Company
    {
        public string Name { get; set; }    
        public string CnpjNumber { get; set; }
        public string UrlComplementaryList { get; set; }
        public ElectronicChannel ElectronicChannel { get; set; }        
    }
}