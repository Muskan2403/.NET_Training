using System;

namespace PharmacyMedicineSystem;

public class InvalidExpiryYearException: Exception
{
    public InvalidExpiryYearException(string errorMessage) : base(errorMessage)
    {
        
    }
}
