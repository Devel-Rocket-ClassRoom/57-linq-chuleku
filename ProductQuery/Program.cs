using System;
using System.Collections.Generic;
using System.Linq;

List<Product> products = new List<Product>
{
    new Product("Laptop","Electronics",1200),
    new Product("Mouse","Electronics",25),
    new Product("Keyboard","Electronics",75),
    new Product("Shirt","Clothing",50),
    new Product("Pants","Clothing",100),
    new Product("Desk","Furniture",250),
    new Product("Chair","Furniture",150),
    new Product("Monitor","Electronics",300),
};
Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
var qurey1 = from p in products
             where p.Price >=100
             select p;
foreach(var product in qurey1)
{
    Console.WriteLine(product.Name);
}
Console.WriteLine();
Console.WriteLine("=== 문제 2: Electronics 카테고리 ===");
var qurey2 = from p in products
             where p.Category =="Electronics"
             select p;
foreach( var product in qurey2)
{
    Console.WriteLine($"{product.Name} - {product.Category} - {product.Price}원"); 
}
Console.WriteLine();
Console.WriteLine("=== 문제 3: 이름순 정렬 ===");
var qurey3 = from p in products
             orderby p.Name
             select p;
foreach( var product in qurey3)
{
    Console.WriteLine(product.Name); 
}
Console.WriteLine();
Console.WriteLine("=== 문제 4: 평균 가격 ===");
var average = products.Average(p=>p.Price);
Console.WriteLine($"{average}원");
Console.WriteLine();
Console.WriteLine("=== 문제 5: 가장 저렴한 상품 ===");
var cheap = products.MinBy(p=>p.Price);
Console.WriteLine($"{cheap.Name} - {cheap.Price}원");
Console.WriteLine();
Console.WriteLine("=== 문제 6: 가장 비싼 상품 ===");
var expensive = products.MaxBy(p=>p.Price);
Console.WriteLine($"{expensive.Name} - {expensive.Price}원");
Console.WriteLine();
Console.WriteLine("=== 문제 7: Electronics 평균 가격 ===");
var eaverage = products.Where(p => p.Category == "Electronics").Average(p => p.Price);
Console.WriteLine($"{eaverage}원");
Console.WriteLine();
Console.WriteLine("=== 문제 8: 'O' 포함 상품 (대문자) ===");
var qurey8 = from p in products
             where p.Name.ToUpper().Contains("O")
             select p.Name;
foreach( var product in qurey8)
{
    Console.WriteLine(product.ToUpper());
}
Console.WriteLine();
Console.WriteLine("=== 문제 9: Clothing 역순 ===");
var qurey9 = from p in products
             where p.Category=="Clothing"
             orderby p.Name descending
             select p.Name;
foreach(var product in qurey9)
{
    Console.WriteLine(product); 
}
Console.WriteLine();
Console.WriteLine("=== 문제 10: 가격 50~300, 복합 정렬 ===");
var qurey10 = from p in products
              where p.Price>=50&&p.Price<=300
              orderby p.Price
              select p;
foreach( var product in qurey10)
{
    Console.WriteLine($"{product.Name} - {product.Price}원"); 
}