using NewsPaper.Data;

namespace NewsPaper.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string ClientId { get; set; }

        public ApplicationIdentityUser Client { get; set; }

        public int RubricId { get; set; }

        public Rubric Rubric { get; set; }

        public int PositionId { get; set; }

        public Position Position { get; set; }

        public int PrintingId { get; set; }

        public Printing Printing { get; set; }

        public int Publications { get; set; }

        public float Area { get; set; }

        public float Price { get; set; }

        public DateTime DateFirst { get; set; }

        public string Text { get; set; }

        public string PhotoName { get; set; }

        public bool IsApproved { get; set; }

        public int ContractId { get; set; }

        public Contract Contract { get; set; }
    }
}
