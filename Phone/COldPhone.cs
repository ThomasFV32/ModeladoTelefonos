using System;
using Entity;
using Class;
using Interface;
namespace Phone
{
    public class COldPhone
    {
        private ICalleable calleable;
        public string ToCall(ICalleable calleable,Contact contact, DateTime startTime)
        {
            return calleable.ToCall(contact,startTime);
        } 
        public string ReciveCall(ICalleable calleable,Contact contact, DateTime startTime)
        {
            return calleable.ReciveCall(contact,startTime);
        } 
        public string CutCall(ICalleable calleable, DateTime endTime)
        {
            return calleable.CutCall(endTime);
        }
    }
}