using System;

namespace PharmacyMedicineSystem;

public class MedicineNotFoundException : Exception
{
    public MedicineNotFoundException(string errorMessage): base(errorMessage)
    {
        
    }
}
