using System;
using System.Collections.Generic;
using System.Linq;

List<GameItem> item = new List<GameItem>
{
    new GameItem("나무 검","무기","일반",100,3),
    new GameItem("강철 대검","무기","희귀",800,1),
    new GameItem("용의 검","무기","전설",5000,1),
    new GameItem("가죽 갑옷","방어구","일반",200,2),
    new GameItem("미스릴 갑옷","방어구","희귀",1200,1),
    new GameItem("드래곤 갑옷","방어구","전설",8000,0),
    new GameItem("체력 물약","소비","일반",50,10),
    new GameItem("마나 물약","소비","일반",80,5),
    new GameItem("고급 물약","소비","희귀",500,0),
    new GameItem("엘릭서","소비","전설",3000,2)
};
var qurey1 = from i in item
             where i.Price>=500
             orderby i.Price descending
             select i;

Console.WriteLine("=== 쿼리 1: 가격 500 이상 (가격 내림차순) ===");
foreach(var i  in qurey1)
{
    Console.WriteLine($"{i.Name} - {i.Type} - {i.Price}원");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 2: 무기타입 (등급순) ===");
var qurey2 = from i in item
             where i.Type =="무기"
             select i;
foreach(var i in qurey2)
{
    Console.WriteLine($"{i.Name} - {i.Grade} - {i.Price}원");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 3: 총 가치 1000 이상 ===");
var qurey3 = from i in item
             let total = i.Price * i.Quantity
             where total > 1000
             select new { i.Name, Total = total };
foreach(var i in qurey3)
{
    Console.WriteLine($"{i.Name} - 총 가치: {i.Total}");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 4: 품절 아이템 (이름순) ===");
var qurey4 = from i in item
             where i.Quantity == 0
             orderby i.Name
             select i;
foreach(var i in qurey4)
{
    Console.WriteLine($"{i.Name}");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 5: 전설 등급 (이름과 가격) ===");
var qurey5 = from i in item
             where i.Grade == "전설"
             select i;
foreach(var i in qurey5)
{
    Console.WriteLine($"{i.Name} - {i.Price}원");
}
