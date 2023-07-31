﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDetails { get; set; }
        public string CategoryIcon { get; set; }
        public ICollection<Training> Trainings { get; set; }

    }
}
