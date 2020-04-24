﻿namespace core3._1_mvc_monolith.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PizzaId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Pizza Pizza { get; set; }
        public Order Order { get; set; }
    }
}
