﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public User User { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<Dish> OrderDishes { get; set; }
    }
}
