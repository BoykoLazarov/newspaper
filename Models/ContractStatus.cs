namespace NewsPaper.Models
{
    public class ContractStatus
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
