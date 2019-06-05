using System.IO;
using System.Collections.Generic;
using System.Collections;
using Entity;
namespace Interface
{
    public interface ILContact
    {
        string SaveContact(Contact contact);
        string ModifyContact(Contact contact);
        string DeleteContact(Contact contact);
        Contact Search(Contact contact);  

    }
}