using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    interface IFrucht
    {
        
    }

    interface IObserver<T>
    {
        void update(T data);
    }

    
    interface Iobserverable<T,B>
    {
        void addObserver(T observer);
        void removeObserver(T observer);
        void notify(B data);
    }
}
