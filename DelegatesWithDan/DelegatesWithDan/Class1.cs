using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWithDan
{
    class Class1
    {
        

        public delegate void SendCount(int counter);

        public event EventHandler WorkHalfWay;
        public event EventHandler WorkComplete;

        SendCount del1;
        public event SendCount send
        {
            add
            {
                Debug.WriteLine("Adding delegate " + value);
                del1 = (SendCount)Delegate.Combine(del1, value);
            }
            remove
            {
                Debug.WriteLine("Removing delegate " + value);
                del1 = (SendCount)Delegate.Remove(del1, value);
            }
        }

        SendCount del2;

        public Class1()
        {
            SendCount del = new SendCount(Count);
            del2 = new SendCount(Log);
            del += del2 + new SendCount(MoreStuff);
            doWork(del);
        }

        public void doWork(SendCount del)
        {
            del(0);
            del -= del2;
            del(5);
        }

        void Count(int counter){Debug.WriteLine("Counter reached " + counter);}
        void Log(int counter){Debug.WriteLine("Log counter " + counter);}
        void MoreStuff(int counter){Debug.WriteLine("Multiply " + (counter * counter));}
    }
}
