﻿using System.Collections.Generic;
using core3._1_mvc_monolith.Models;

namespace core3._1_mvc_monolith.ViewModels
{
    public class PizzasListViewModel
    {
        public IEnumerable<Pizza> Pizzas { get; set; }
        public string CurrentCategory { get; set; }
    }
}
