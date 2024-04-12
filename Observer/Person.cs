using System;
using System.Collections.Generic;

namespace Observer
{
    class Person : IObserver<Frucht>
    {
        private string personName;
        public string PersonName { get => personName; set => personName = value; }
   
        private string vitaminemangel;
        public string Vitaminemangel { get => vitaminemangel; set => vitaminemangel = value; }
        

        public Person(string name, string v_mangel)
        {
            PersonName = name;
            vitaminemangel = v_mangel;
        }
        public void update(Frucht fruchtData)
        {
            if (fruchtData.Vitamine == Vitaminemangel)
            {
                Console.WriteLine($"Hallo {personName}!. wir haben dieses neue Frucht :{ fruchtData.Fruchtname}, mit dem Vitamie: {fruchtData.Vitamine} für dein Vitamin-{Vitaminemangel} Mangel gefunden.");
            }
           
           
        }






    }
}
