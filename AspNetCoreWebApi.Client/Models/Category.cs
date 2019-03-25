﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.Models
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
