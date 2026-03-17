using System;
using System.Collections.Generic;
using System.Linq;

List<Student> students = new List<Student>
{
    new Student("김철수","수학",85),
    new Student("김철수","영어",78),
    new Student("이영희","수학",92),
    new Student("이영희","영어",88),
    new Student("박민수","수학",76),
    new Student("박민수","영어",82),
    new Student("정지은","수학",95),
    new Student("정지은","영어",91)
};
Console.WriteLine("=== 문제 1: 85점 이상 ===");
var query1 =from s in students
            where s.Score>=85
            select s;
foreach(var q in query1)
{
    Console.WriteLine($"{q.Name} - {q.Subject}: {q.Score}점");
}
Console.WriteLine();
Console.WriteLine("=== 문제 2: 수학 과목 ===");
var query2 = from s in students
             where s.Subject =="수학"
             select s;
foreach( var q in query2)
{
    Console.WriteLine($"{q.Name} - {q.Subject}: {q.Score}점");
}
Console.WriteLine();
Console.WriteLine("=== 문제3: 점수 내림차순 ===");
var query3 = from s in students
             orderby s.Score descending
             select s;
foreach(var q in query3)
{
    Console.WriteLine($"{q.Name} - {q.Subject}: {q.Score}점");
}
Console.WriteLine();
Console.WriteLine("=== 문제 4: 전체 평균 ===");
var average = students.Average(s => s.Score);
Console.WriteLine($"{average}점");
Console.WriteLine();
Console.WriteLine("=== 문제 5: 수학 최고/최저 점수 ===");
var max = students.Where(s => s.Subject == "수학").Max(s => s.Score);
var min = students.Where(s => s.Subject == "수학").Min(s => s.Score);
Console.WriteLine($"최고: {max}점");
Console.WriteLine($"최저: {min}점");
Console.WriteLine();
Console.WriteLine("=== 문제 6: 영어 90점 이상 존재 여부 ===");
var any = students.Where(s => s.Subject == "영어").Any(s => s.Score >= 90);
Console.WriteLine(any);
Console.WriteLine();
Console.WriteLine("=== 문제 7: 모두 70점 이상 여부 ===");
var any2 = students.All(s => s.Score >= 70);
Console.WriteLine(any2);
Console.WriteLine();
Console.WriteLine("=== 문제 8: 학생 이름 (중복 제거) ===");
var dis1 = students.DistinctBy(s => s.Name);
foreach (var d in dis1)
{
    Console.WriteLine(d.Name);
}
Console.WriteLine();
Console.WriteLine("=== 문제 9: 수학 최고점 학생 ===");
var mathmax = students.Where(s => s.Subject == "수학").Max(s => s.Name);
Console.WriteLine(mathmax);
Console.WriteLine();
Console.WriteLine("=== 문제 10: 과목별 정렬 ===");
var qurey10 = from s in students
              orderby s.Score descending
              orderby s.Subject
              select s;
foreach(var q in qurey10)
{
    Console.WriteLine($"{q.Name} - {q.Subject}: {q.Score}점");
}