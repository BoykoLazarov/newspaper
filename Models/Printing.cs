﻿namespace NewsPaper.Models
{
    public class Printing
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
