using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// 1. 메서드 구문 기본 사용법
/*int[] num = { 1, 2, 3, 4, 5 };
IEnumerable<int> result = num.Where(n => n > 3);
foreach(int n in result)
{
    Console.WriteLine(n);
}*/

// 2. Where - 필터링
/*string[] person = { "Tom", "Dick", "Harry", "Mary", "Jay" };
IEnumerable<string> result = person.Where(x => x.Contains("a"));
foreach (string s in result)
{
    Console.WriteLine(s);
}*/

// 3. Select - 변환
/*string[] person = { "Tom", "Dick", "Harry" };
var result = person.Select(x => x.ToUpper());
foreach (var item in result)
{
    Console.WriteLine(item);
}*/

// 4. OrderBy - 오름차순 정렬
/*string[] color = { "Red", "Green", "Blue" };
var result = color.OrderBy(c => c);
foreach(var item in result)
{
    Console.WriteLine(item);
}*/

// 5. OrderByDesending - 내림차순 정렬
/*int[] num = { 3, 1, 4, 1, 5, 9, 2, 6 };
var result = num.OrderByDescending(n => n);
foreach (var item in result)
{
    Console.Write($"{item} ");
}*/
//6. 쿼리 연산자 체이닝
/*string[] person = { "Tom", "Dick", "Harry", "Mary", "Jay" };
var result = person.Where(n => n.Contains("a"))
    .OrderBy(n => n.Length)
    .Select(n => n.ToUpper());

foreach(var n  in result)
{
    Console.WriteLine(n);
}*/

// 7. 쿼리 구문 기본 구조
/*int[] num = { 1, 2, 3, 4, 5 };
var result = from n in num
             where n % 2 == 0
             select n;
foreach (var n in result)
{
    Console.WriteLine(n);
}*/

// 8. 쿼리 구문 필터링과 정렬
/*string[] person = { "Tom", "Dick", "Harry", "Mary", "Jay" };
var result = from p in person
             where p.Contains("a")
             orderby p.Length
             select p.ToUpper();
foreach (var item in result)
{
    Console.WriteLine(item);
}*/

// 9. 메서드 구문과 쿼리 구문 비교
int[] num = { 3, 2, 1, 4, 5 };
var result1 = num.Where(n => n % 2 == 1)
    .OrderBy(n => n);
Console.WriteLine("메서드 구문:");
foreach (var n  in result1)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
var result = from n in num
             where n % 2 == 1
             orderby n
             select n;




Console.WriteLine("쿼리 구문:");
foreach (var n in result)
{
    Console.Write($"{n} ");
}