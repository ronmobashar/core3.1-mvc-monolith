﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core3._1_mvc_monolith.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
