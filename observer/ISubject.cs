using System;
namespace observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver pObserver);
        void RemoveObserver(IObserver pObserver);
        void NotifyObservers(string pContent);
    }
}
