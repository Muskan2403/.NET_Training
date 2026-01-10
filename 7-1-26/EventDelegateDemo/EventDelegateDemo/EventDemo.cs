using System;

namespace EventDelegateDemo
{
    

    interface IBank
    {
        bool OpenAct(string details);
        List<string> Genstatement();
    }
    interface RBI
    {

    }

    public class HDFC : IBank
    {
        delegate void Tranaction(int actNo, string date, int amount);

        public event Transaction Debit;
        public event Transaction Credit;
        public List<string> Genstatement()
        {
            throw new NotImplementedException();
        }

        public bool OpenAct(string details)
        {
            throw new NotImplementedException();
        }
    }

    class Axis : IBank
    {
        public List<string> Genstatement()
        {
            throw new NotImplementedException();
        }

        public bool OpenAct(string details)
        {
            throw new NotImplementedException();
        }
    }

    class HDFCJalandhar : HDFC
    {

    }
    public class EventDemo
    {
        public static void EventDemoMain(string args)
        {
            HDFCJalandhar hdfcJal = new HDFCJalandhar();
            hdfcJal.Credit += HdfcJal_Credit;
        }

    }
}
