﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
    public class ProductSearchResult
    {
        //creating data transfer object - DTO
        public List<Product> Products { get; set; } =new List<Product>();
        public int Pages { get; set; }  
        public int CurrentPage { get; set; }
    }
}
