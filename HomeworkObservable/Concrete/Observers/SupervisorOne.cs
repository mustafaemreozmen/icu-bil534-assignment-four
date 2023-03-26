using System;
using HomeworkObservable.Abstract;

public class SupervisorOne : Observer
{
    public SupervisorOne(Subject subject)
    {
        subject.RegisterObserver(this);
    }
    public override void Notify(string homeworkName)
    {
        CheckHomework(homeworkName);
    }
    private void CheckHomework(string homeworkName)
    {
        Console.WriteLine($"I approve this {homeworkName} homework");
    }
}