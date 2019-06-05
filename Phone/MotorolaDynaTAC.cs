using System;
using Class;
using Interface;
using Entity;
namespace Phone
{
    public class MotorolaDynaTAC
    {
        CPhone phone= new CPhone();
        ICalleable calleable;
        public void ToCall(int number)
        {
            if(calleable==null)
            {
                calleable = new CCalleable();
                var contact = new Contact(number,number.ToString());
                Console.WriteLine(phone.ToCall(calleable,contact,DateTime.Now));
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