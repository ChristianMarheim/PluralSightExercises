using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_buttons
{
    public sealed class Mediator
    {
        private readonly static Mediator _Instance = new Mediator();

        private Mediator() { }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public event EventHandler<PrintDataEventArgs> InputData;

        public void OnInputData(object sender, PrintDataEventArgs e)
        {
            OutputData(sender, e);
        }

        public delegate void OutputDataType(object sender, PrintDataEventArgs e);

        public OutputDataType OutputData;
    }
}
