using System.Collections.Immutable;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Globalization;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using Entity;
using Interface;
using System.Linq.Expressions;
namespace Class
{
    public class CLContact : Contact, ILContact
    {
        List<Contact> lContact;

        public CLContact()
        {
            lContact = new List<Contact>();
        }

        public string DeleteContact(Contact xe)
        {
            if(lContact!=null)
            {
                var index = lContact.FindIndex(x=> x.Number == Search(xe).Number);
                if(index != -1)
                {
                    Contact temp = lContact[index];
                    lContact.RemoveAt(index);
                    return "Delete contact: " + temp.Name +"\nNumber: " +temp.Number.ToString();
                }
            }
            return "There are no contacts";
        }

        /*Terminar Modificar */
        public string ModifyContact(Contact contactM)
        {
            return "";
        }

        public Contact Search(Contact temp)
        {
            Func<Contact,bool> fillter_age = (p) => temp.Address is null || temp.Address == "" || p.Address == temp.Address;
            Func<Contact,bool> fillter_name = (p) => temp.Name is null || temp.Name == "" || p.Name == temp.Name;
            Func<Contact,bool> fillter_email = (p) => temp.Email is null || temp.Email == "" || p.Email == temp.Email;
            Func<Contact,bool> fillter_number = (p) => temp.Number == 0 || p.Number == temp.Number;
        
            Func<Contact,bool> filter = (p) => (fillter_name(p) && fillter_age(p) && fillter_email(p) && fillter_number(p));
            
            return (from p in lContact where filter(p) select p).Single();
        }

        protected void OrderContact()
        {
            List<Contact> temp = lContact.OrderBy(x => x.Name).ToList();
            lContact = temp;
        }

        public string SaveContact(Contact contact)
        {
            lContact.Add(contact);
            OrderContact();
            return "Contact add";
        }
    }
}