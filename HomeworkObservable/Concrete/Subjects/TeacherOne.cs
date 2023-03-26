using HomeworkObservable.Abstract;
using System;
using System.Collections.Generic;
public class TeacherOne : Subject
{
    public TeacherOne()
    {
        Observers = new List<Observer>();
    }

    public override void RegisterObserver(Observer o)
    {
        Observers.Add(o);
    }

    public override void RemoveObserver(Observer o)
    {
        Observers.Remove(o);
    }
    public override void NotifyObservers(string homeworkName)
    {
        foreach (var observer in Observers)
        {
            observer.Notify(homeworkName);
        }
    }
    public void GiveHomework(string homeworkName)
    {
        Console.WriteLine("Hahahaha, homework!");
        NotifyObservers(homeworkName);
    }
}