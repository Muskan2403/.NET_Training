using System;
using System.Collections.Generic;

namespace PharmacyMedicineSystem;

public class MedicineUtility
{
    private SortedDictionary<int, List<Medicine>> medicines = new SortedDictionary<int, List<Medicine>>();
    public void AddMedicine(Medicine medicine)
    {
        if(medicine.Price <= 0)
        {
            throw new InvalidPriceException("Invalid Price!");
        }

        if(medicine.ExpiryYear < DateTime.Now.Year)
        {
            throw new InvalidExpiryYearException("Invalid Expiry Year!");
        }

        foreach(var entry in medicines.Values)
        {
            foreach(var med in entry)
            {
                if(med.Id == medicine.Id)
                {
                    throw new DuplicateMedicineException("Medicine Already Exists!");
                } 
            }
        }

        if (!medicines.ContainsKey(medicine.ExpiryYear))
        {
            medicines[medicine.ExpiryYear] = new List<Medicine>();
        }

        medicines[medicine.ExpiryYear].Add(medicine);

    }

    public void GetAllMedicine()
    {
        foreach(var year in medicines)
        {
            foreach(var med in year.Value)
            {
                Console.WriteLine($"Details: {med.Id} {med.Name} {med.Price} {med.ExpiryYear}");
            }
        }
    }

    public void UpdateMedicinePrice(string id, int newPrice)
    {
        if(newPrice <= 0)
        {
            throw new InvalidPriceException("Invalid Price!");
        }

        foreach(var entry in medicines.Values)
        {
            foreach(var med in entry)
            {
                if(med.Id == id)
                {
                    med.Price = newPrice;
                    return;
                }
            }
        }

        throw new MedicineNotFoundException("Medicine not found!");
    }
}
