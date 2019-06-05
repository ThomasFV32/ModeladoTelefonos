using System;
using Entity;
using Interface;

namespace Class
{
    public class CCalleable : ICalleable {

        protected Contact contactCall= null;
        private DateTime startTime { get; set; }

        private DateTime endTime { get; set; }

        protected TimeSpan time { get; private set; }

        public string ToCall(Contact contactNumber, DateTime startTime)
        {
            contactCall= contactNumber;
            this.startTime = startTime;
            return "Outgoing: " + this.contactCall.Name;
        }

        public string ReciveCall(Contact contactNumber, DateTime startTime)
        {
            contactCall= contactNumber;
            this.startTime = startTime;
            return "Incoming: " + this.contactCall.Name;
        }

        public string CutCall(DateTime endTime)
        {
            this.endTime= endTime;
            this.time= this.endTime - this.startTime;
            return "Call time: "+time.ToString();
        }
    }
}