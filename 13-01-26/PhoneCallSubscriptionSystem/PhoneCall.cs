using System;

namespace PhoneCallSubscriptionSystem;

public class PhoneCall
{
    public delegate void Notify();

    public event Notify PhoneCallEvent
    {
        add
        {
            OnSubscribe();
        }
        remove
        {
            OnUnSubscribe();
        }
    }

    public string Message { get; private set; }

    private void OnSubscribe()
    {
        Message = "Subscribed to Call";
        Console.WriteLine(Message);
    }

    private void OnUnSubscribe()
    {
        Message = "Unsubscribed to Call";
        Console.WriteLine(Message);
    }

    public void MakeAPhoneCall(bool notify)
    {
        if(notify == true)
        {
            PhoneCallEvent += null;
        }
        else if(notify == false)
        {
            PhoneCallEvent -= null;
        }
        else
        {
            Console.WriteLine("No action taken.");
        }
    }
}
