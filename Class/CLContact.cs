using System.Collections.Generic;
using Entity;
using Interface;
namespace Class
{
    public class CLContact : ILContact
    {
        List<Contact> lContact;

        public CLContact()
        {
            lContact = new List<Contact>();
        }

        public string DeleteContact(int number)
        {
            if(lContact!=null)
            {
                var index = lContact.FindIndex(x=> x.Number == number);
                Contact temp = lContact[index];
                lContact.RemoveAt(index);
                return "Delete contact: " + temp.Name +"\nNumber: " +temp.Number.ToString();
            }
            return "There are no contacts";
        }

        public string ModifyContact()
        {
             
        }

        public void OrderContact()
        {
            throw new System.NotImplementedException();
        }

        public string SaveContact()
        {
            throw new System.NotImplementedException();
        }
    }
}