using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alex", "A");
            Person person2 = new Person("Michael", "B12");
            Person person3 = new Person("Sara", "C");

            Observerable observerable = new Observerable();
            observerable.addObserver(person1);
            observerable.addObserver(person2);
            observerable.addObserver(person3);

            Frucht frucht1 = new Frucht("Aplle", "A");
            Frucht frucht2 = new Frucht("Kivi", "A");
            Frucht frucht3 = new Frucht("Orange", "C");

            observerable.addFrucht(frucht1);
            observerable.addFrucht(frucht2);
            observerable.addFrucht(frucht3);


            Console.ReadKey();

        }
    }
}
