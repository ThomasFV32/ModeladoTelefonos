using System;
using Entity;
namespace Interface
{
    public interface ICalleable
    {
        string ToCall(Contact contactNumber, DateTime startTime);
        string ReciveCall(Contact contactNumber, DateTime startTime);
        string CutCall(DateTime endTime);
    }
}