using System;
using System.Collections.Generic;
using System.Text;

class Product
{
    public string Name { get; private set; }
    public string Category { get; private set; }
    public int Price { get; private set; }
    public Product(string name,string category,int price)
    {
        Name = name;
        Category = category; 
        Price = price;
    }
}