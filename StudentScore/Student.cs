using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public string Name { get; private set; }
    public string Subject { get; private set; }
    public int Score { get; private set; }
    public Student(string name, string subject, int score)
    {
        Name = name;
        Subject = subject; 
        Score = score;
    }
}