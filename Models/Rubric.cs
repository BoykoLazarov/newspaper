namespace NewsPaper.Models
{
    public class Rubric
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
