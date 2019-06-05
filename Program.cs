using System;
using Entity;
using Phone;

namespace Modelado
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorolaDynaTAC moto = new MotorolaDynaTAC();
            moto.ToCall(1160080562);
            System.Threading.Thread.Sleep(2000);
            moto.CutCall();           
        }
    }
}
