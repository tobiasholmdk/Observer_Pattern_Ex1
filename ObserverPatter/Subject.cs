using System;
using System.Collections.Generic;

namespace ObserverPatter
{
    public abstract class Subject
    {
        private List<IObserver> tubz = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            tubz.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            tubz.Remove(observer);
        }
        
        public void Notify()
        {
            Console.WriteLine("Notifying...");

            foreach (var observer in tubz)
            {
                observer.update();
            }
        }
    }
}