﻿namespace Basket.API.Entities
{
    public class ShoppingCartItem
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
