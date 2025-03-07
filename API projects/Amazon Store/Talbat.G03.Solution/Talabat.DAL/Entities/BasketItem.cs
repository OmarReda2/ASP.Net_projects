﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.DAL.Entities
{
    // ... p2.1
    public class BasketItem:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }

    // p2.3 create CustomerBasket
    // p2.3 go to CustomerBasket ...
}
