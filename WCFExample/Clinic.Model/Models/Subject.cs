using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
  public abstract class Subject
    {
        private ArrayList observers = new ArrayList();
        public void AddObservers(Observer observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            // Notify the observers by looping through
            // all the registered observers.

            foreach (Observer observer in observers)
            {
                observer.UpdateConsult(this);
            }
        }
    }
}
