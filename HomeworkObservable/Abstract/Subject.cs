namespace HomeworkObservable.Abstract;

public abstract class Subject
{
    public List<Observer> Observers { get; set; }
    public abstract void RegisterObserver(Observer o);
    public abstract void RemoveObserver(Observer o);
    public abstract void NotifyObservers(string payload);

}