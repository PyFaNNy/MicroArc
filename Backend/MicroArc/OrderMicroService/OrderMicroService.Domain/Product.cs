﻿namespace OrderMicroService.Domain;

public class Product
{
    public Guid ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public ICollection<OrderLine> OrderLines { get; set; }
}