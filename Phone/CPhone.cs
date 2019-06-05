using System;
using Entity;
using Interface;
using Class;
namespace Phone
{
    public class CPhone
    {
        private ICalleable calleable;
        private ILContact schedule;
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

        public string SaveContact(Contact contact)
        {
            return schedule.SaveContact(contact);
        }

        public string DeleteContact(Contact contact)
        {

            return schedule.DeleteContact(contact);
        }
    }
}