﻿namespace BasketMicroService.Domain;

public class Product
{
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public string ImageUrl { get; set; }
    public ICollection<BasketItem> BasketItems { get; set; }
}