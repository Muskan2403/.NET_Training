using System;

namespace PharmacyMedicineSystem;

public class InvalidPriceException :Exception
{
    public InvalidPriceException(string errorMessage):base(errorMessage)
    {
        
    }
}
