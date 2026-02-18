using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Shipment_System;
public class ShipmentDetails: Shipment
{
    public bool ValidateShipmentCode()
    {
        string pattern = @"^GC#[0-9]{4}$";

        if(Regex.IsMatch(ShipmentCode, pattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double CalculateTotalCost()
    {
        double ratePerKg = 0;
        if(TransportMode == "Sea")
        {
            ratePerKg = 15.00;
        }
        else if(TransportMode == "Air")
        {
            ratePerKg = 50.00;
        }
        else if(TransportMode == "Land")
        {
            ratePerKg = 25.00;
        }
        double total = (Weight * ratePerKg) + Math.Sqrt(StorageDays);

        return total;
    }
}
