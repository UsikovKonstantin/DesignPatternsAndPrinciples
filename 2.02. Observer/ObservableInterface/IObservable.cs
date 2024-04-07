using _02._Observer.ObserverInterface;

namespace _02._Observer.ObservableInterface;

public interface IObservable
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(object obj);
}
