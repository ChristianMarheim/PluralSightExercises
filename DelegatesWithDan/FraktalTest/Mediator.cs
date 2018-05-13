using System;
using System.Collections.Generic;
using System.Text;

namespace FraktalTest
{
    public sealed class Mediator
    {
        private readonly static Mediator _Instance = new Mediator();

        private Mediator() { }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public event EventHandler<PrintDataEventArgs> PrintData;

        public event EventHandler<StatusChangeEventArgs> ChangeStatus;

        public void OnPrintData(PrintDataEventArgs e)
        {
            Console.WriteLine("Output from " + e.Name + ":" + e.Data);

        }

        public void OnChangeStatus(StatusChangeEventArgs e)
        {
            if(!e.IsComplete && e.HasStarted)
                Console.WriteLine("The Job " + e.Name + " has started");
            else if (e.IsComplete && e.HasStarted)
                Console.WriteLine("The Job " + e.Name + " has completed");
        }


    }
}
