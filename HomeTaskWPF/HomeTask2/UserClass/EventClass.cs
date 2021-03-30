using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask2.UserClass;

namespace HomeTask2.UserClass
{
    public delegate void CountTwo(object sender, CountUpEvent e);
   
    public class CountUpEvent : EventArgs
    {
        public object _resultat { get; set; }
    }

    
    public class EventClass
    {
        public event CountTwo OnCountProcess;
            public void Process(object resultat)
            {
                if (OnCountProcess != null)
                {
                    var e = new CountUpEvent() { _resultat = resultat };
                    OnCountProcess(this, e);
                }
            }
    }

}   

