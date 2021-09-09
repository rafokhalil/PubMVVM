﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMVVM.Model
{
    public class Pub:Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Volume { get; set; }
        public string ImagePath { get; set; }
        public int Count { get; set; }
        public override string ToString()
        {
            return $"{Name}       -      {Count} pcs     -       {Price*Count} Azn"; 
        }
    }
}
