using System;

namespace PhoneCallSubscriptionSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneCall phoneCall = new PhoneCall();

            phoneCall.MakeAPhoneCall(true);

            phoneCall.MakeAPhoneCall(false);
        }
    }
}