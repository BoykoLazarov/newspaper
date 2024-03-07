using System.ComponentModel.DataAnnotations;

namespace NewsPaper.Models
{
    public class Contract
    {
        [Key]
        public int Number { get; set; }

        public Order Order { get; set; }

        public DateTime DateLast { get; set; }

        public int ContractStatusId { get; set; }

        public ContractStatus Status { get; set; }
    }
}
