using System;
using Entity;
using Interface;
using Class;

namespace Phone
{
    public class Nokia1100
    {
        ILContact lcontact = new CLContact();
        CPhone phone= new CPhone();
        ICalleable calleable;
        

        public void SaveContact(Contact contact)
        {
            Console.WriteLine(lcontact.SaveContact(contact));
        }

        public void DeleteContact(Contact xe)
        {
            Console.WriteLine(lcontact.DeleteContact(xe));
        }
        
        public void ToCall(Contact contact)
        {
            if(calleable==null)
            {
                calleable = new CCalleable();
                Console.WriteLine(phone.ToCall(calleable,lcontact.Search(contact),DateTime.Now));
            }
            else Console.WriteLine("Is already in a call");
            Linea();
        }
        public void recibeCall(int number)
        {
            if(calleable==null)
            {
                calleable = new CCalleable();
                var contact = new Contact(number,number.ToString());
                Console.WriteLine(phone.ReciveCall(calleable,contact,DateTime.Now));
            }
            Linea();
        }
        public void CutCall()
        {
            if(calleable!=null)
            {
                Console.WriteLine(phone.CutCall(calleable,DateTime.Now));
                calleable=null;
            }
            else Console.WriteLine("Can not cut a call that does not exist");
            Linea();
        }
        private void Linea()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.Write("-");
            }
                Console.WriteLine();
        }
    }
}