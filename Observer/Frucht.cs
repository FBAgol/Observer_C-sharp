using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Frucht : IFrucht
    {
        private string fruchtname;
        private string vitamine ;

        public string Fruchtname { get => fruchtname; set => fruchtname = value; }
        public string Vitamine { get => vitamine; set => vitamine = value; }

        public  Frucht (string frucht, string vitamine)
        {
             Fruchtname=frucht;
             this.vitamine=vitamine;
        }
    }
}
