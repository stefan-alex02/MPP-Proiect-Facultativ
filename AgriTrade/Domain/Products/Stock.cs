﻿using Domain.Users;

namespace Domain.Products;

public class Stock : Entity<int> {
    public Product Product { get; set; } = null!;
    public Producer Producer { get; set; } = null!;
    public float Amount { get; set; }
    public string Unit { get; set; } = null!;
    public float Price { get; set; }
    
    public string Description { get; set; } = null!;
    
    public Stock() : base(default) {
    }
    
    public Stock(int id, Product product, Producer producer, float amount, string unit, float price, string description) : 
        base(id) {
        Product = product;
        Producer = producer;
        Amount = amount;
        Unit = unit;
        Price = price;
        Description = description;
    }

}