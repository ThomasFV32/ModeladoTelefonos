using Entity;
namespace Interface
{
    public interface IMessageable
    {
        string SendMessage(string body , Contact contact);
        string ReceiveMessage(string body, Contact contact);
    }
}