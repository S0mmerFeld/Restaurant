﻿namespace Data.Entities
{
    public class Ingredient : BaseEntity
    {        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}