using Interface;
using Entity;
namespace Class
{
    public class CMessageable : IMessageable
    {
        string[] message= new string[2];
        public string ReceiveMessage(string body, Contact contact)
        {
            message[0]= contact.Name.ToString();
            message[1]= body;
            return "Sending to" + message[0]+"....";
        }

        public string SendMessage(string body, Contact contact)
        {
            return "Contact: "+contact.Name +"\nBody:\n"+body;
        }
    }
}