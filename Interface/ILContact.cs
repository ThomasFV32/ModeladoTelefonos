using System.IO;
using System.Collections.Generic;
using System.Collections;
using Entity;
namespace Interface
{
    public interface ILContact
    {
        string SaveContact();
        string ModifyContact();
        string DeleteContact(int number);
        void OrderContact();

    }
}