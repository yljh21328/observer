using System;
using System.Collections.Generic;

namespace observer
{
    public class NewspaperOffice : ISubject
    {
        List<IObserver> observerList;
        public NewspaperOffice()
        {
            observerList = new List<IObserver>();
        }

        public void NotifyObservers(string pContent)
        {
            foreach (IObserver observer in observerList)
            {
                observer.Update(pContent);
            }
        }

        public void RegisterObserver(IObserver pObserver)
        {
            observerList.Add(pObserver);
        }

        public void RemoveObserver(IObserver pObserver)
        {
            if (observerList.IndexOf(pObserver) >= 0)
            {
                observerList.Remove(pObserver);
            }
        }

        public void SubscribeNewspaper(IObserver pCustomer)
        {
            RegisterObserver(pCustomer);
        }

        public void UnsubscribeNewspaper(IObserver pCustomer)
        {
            RemoveObserver(pCustomer);
        }

        public void SendNewspaper(string pContent)
        {
            Console.WriteLine("Send News ...");
            NotifyObservers(pContent);
        }
    }
}
