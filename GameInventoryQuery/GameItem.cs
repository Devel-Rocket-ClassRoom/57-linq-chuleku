using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class GameItem
{
    public string Name {  get; private set; }
    public string Type { get; private set; }
    public string Grade { get; private set; }
    public int Price { get; private set;  }
    public int Quantity { get; private set; }
    public GameItem(string name, string type, string grade, int price, int quantity)
    {
        Name = name;
        Type = type;
        Grade = grade;
        Price = price;
        Quantity = quantity;
    }
/*    public void PrintInfo()
    {
        Console.WriteLine("|  이름   |    타입   |   등급   |   가격   |   수량   |");
        foreach (GameItem item in Items)
        {
            Console.WriteLine($"|   {item.Name}   |   {item.Type}   |   {item.Grade}   |   {item.Price}   |   {item.Quantity}   |");
        }
    }
    */
}