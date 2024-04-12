using System;
using System.Collections.Generic;

namespace Observer
{
    class Observerable : Iobserverable<Person, Frucht>
    {
        List<Person> observers = new List<Person>();

        public void addObserver(Person observer)
        {
            observers.Add(observer);
        }


        public void removeObserver(Person observer)
        {
            observers.Remove(observer);
        }

        public Frucht addFrucht(Frucht data) {
            notify(data);
            return data;
        }

        public void notify(Frucht fruchtData)
        {
            
            for (int i = 0; i<observers.Count; i++)
            {
                observers[i].update(fruchtData);
            }
            
        }




    }
}
