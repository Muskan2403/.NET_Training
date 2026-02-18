using System;

namespace PharmacyMedicineSystem;

public class DuplicateMedicineException : Exception
{
    public DuplicateMedicineException(string errorMessage): base(errorMessage)
    {
        
    }
}
