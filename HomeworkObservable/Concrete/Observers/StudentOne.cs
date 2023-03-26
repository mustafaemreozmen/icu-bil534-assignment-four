using System;
using HomeworkObservable.Abstract;

public class StudentOne : Observer
{
    public StudentOne(Subject subject)
    {
        subject.RegisterObserver(this);
    }
    public override void Notify(string homeworkName)
    {
        DoHomework(homeworkName);
    }
    private void DoHomework(string homeworkName)
    {
        Console.WriteLine($"I did my {homeworkName} homework!");
    }
}