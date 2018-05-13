using System;

namespace FraktalTest
{
    public class StatusChangeEventArgs : EventArgs
    {
        public bool IsComplete;
        public bool HasStarted;
        public String Name;
    }
}