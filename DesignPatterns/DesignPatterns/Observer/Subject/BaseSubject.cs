using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer.Observers;

namespace Observer.Subject
{
    public abstract class BaseSubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}
