using System;

namespace Assignment2{

    public class CabDetails: Cab
    {
        public bool ValidateBookingID()
        {
            if(BookingID.Length == 6)
            {
                if (BookingID.StartsWith("AC@"))
                {
                    string digits = BookingID.Substring(3);
                    foreach (char c in digits)
                    {
                        if (Char.IsDigit(c))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public double CalculateFareAmount()
        {
            switch (CabType)
            {
                case "HatchBack":
                    {
                        PricePerKm = 10;
                        break;
                    }
                case "Sedan":
                    {
                        PricePerKm = 20;
                        break;
                    }
                case "SUV":
                    {
                        PricePerKm = 30;
                        break;
                    }
                default:
                    {
                        PricePerKm = 0;
                        break;
                    }
            }
            double waitingCharge = Math.Sqrt(WaitingTime);
            double fare = Math.Floor((Distance * PricePerKm + waitingCharge)*100)/100; //while using math.floor, to get 2 decimal places *100/100 is used

            return fare;
        }
    }
}
