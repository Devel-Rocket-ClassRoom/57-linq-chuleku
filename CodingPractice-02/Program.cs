using System;
using System.Collections.Generic;
using System.Linq;

// 1.Sum,Count,Average
/*int[] num = { 1, 2, 3, 4, 5 };
int sum = num.Sum();
int count = num.Count();
double average = num.Average();
Console.WriteLine($"합계: {sum}");
Console.WriteLine($"개수: {count}");
Console.WriteLine($"평균: {average}");*/

// 2. Min,Max
/*int[] num = { 3, 1, 4, 1, 5, 9, 2, 6 };
int min = num.Min();
int max = num.Max();
Console.WriteLine($"최솟값: {min}");
Console.WriteLine($"최댓값: {max}");*/
// 3. 조건부 집계
/*int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int evensum = num.Where(x => x % 2 == 0).Sum();
int countover5 = num.Where(x => x > 5).Count();
Console.WriteLine($"짝수 합계: {evensum}");
Console.WriteLine($"5보다 큰 숫자 개수: {countover5}");*/

// 4. First, Last
/*int[] num = { 10, 20, 30, 40, 50 };
int first = num.First();
int last = num.Last();
Console.WriteLine($"첫 번째:{first}");
Console.WriteLine($"마지막:{last}");*/

// 5. 조건부 요소 선택
/*int[] num = { 1, 2, 3, 4, 5 };
int first = num.Where(x => x > 3).First();
Console.WriteLine($"3보다 큰 첫 번째: {first}");*/

// 6. Take, Skip
/*int[] num = { 10, 20, 30, 40, 50 };
var Take = num.Take(3);
var Skip = num.Skip(2);
Console.WriteLine("처음 3개:");
foreach(var item in Take)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Console.WriteLine("2개 건너뛴 후:");
foreach( var item in Skip)
{
    Console.Write($"{item} ");
}*/

//7. Any,All
/*int[] num = { 1, 2, 3, 4, 5 };
bool any = num.Any();
bool even = num.Any(n=>n%2==0);
bool all = num.All(n => n > 0);
Console.WriteLine($"요소 존재: {any}");
Console.WriteLine($"짝수 존재: {even}");
Console.WriteLine($"모두 양수: {all}");*/

//8. Contains
/*int[] num = { 1, 2, 3, 4, 5 };
bool three = num.Contains(3);
bool ten = num.Contains(10);
Console.WriteLine($"3 포함: {three}");
Console.WriteLine($"10 포함: {ten}");*/

// 9. Distinct
/*int[] num = { 1, 2, 2, 3, 3, 3, 4, 5 };
var dis = num.Distinct().ToArray();
foreach(var i in dis)
{
    Console.Write($"{i} ");
}
*/

// 10. Concat, Union
/*int[] first = { 1, 2, 3 };
int[] second = { 3, 4, 5 };
var concat = first.Concat(second);
Console.WriteLine("Concat:");
foreach(var item in concat)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
var union = first.Union(second);
Console.WriteLine("Union:");
foreach( var item in union)
{
    Console.Write($"{item} ");
}*/

// 11. 지연 실행
/*List<int> num = new List<int> { 1, 2, 3 };
var n = num.Where(n => n > 1);
num.Add(4);
Console.WriteLine("결과:");
foreach(var q  in n)
{
    Console.WriteLine(q);
}*/
// 12.즉시 실행 연산자
/*List<int> num = new List<int> { 1, 2, 3 };
var count = num.Count();
num.Add(4);
Console.WriteLine($"개수: {count}");*/

// 13.ToList로 결과 고정
/*List<int> num = new List<int> { 1, 2, 3 };
var s = num.Where(n => n > 1).ToList();
num.Add(4);
Console.WriteLine("결과:");
foreach(var item in s)
{
    Console.WriteLine(item);
}
*/

//14. Select로 새 타입 생성
/*string[] person = { "홍길동", "김철수", "이영희" };
var result = person.Select(n => new { Name = n, Length = n.Length });

foreach(var p in result)
{
    Console.WriteLine($"이름: {p.Name}, 길이: {p.Length}");
}*/

// 15. 혼합 구문
string[] person = { "Tom", "Dick", "Harry", "Mary", "Jay" };
var count = (from p in person
              where p.Contains("a")
              select p).Count();
Console.WriteLine($"\'a\' 포함 이름 개수: {count} ");
string first = (from p in person
                orderby p
                select p).First();
Console.WriteLine($"알파벳 순 첫 번째: {first}");