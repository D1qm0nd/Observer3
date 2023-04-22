using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subscriber : ASubscriber
    {
        public Subscriber(SubEvent subevent ,SubNotify notify) 
        {
            if (subevent != null && notify != null)
            {
                subEvent += subevent;
                subNotify += notify;
            }
            else throw new ArgumentNullException();
        }
        public override void Notify()
        {
            if (subNotify != null)
            {
                subNotify.Invoke();
            }
            else throw new Exception("subNotify: null"); 
        }

    }
}
