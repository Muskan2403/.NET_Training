using System;

namespace MediSureClinic{
    public class PatientBill
    {
        // Properties
        public int BuildID { get; set; }
        public string PatientName { get; set; }
        public bool HasInsurance { get; set; }
        public decimal ConsultationFee { get; set; }
        public decimal LabCharges { get; set; }
        public decimal MedicineCharges { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalPayable { get; set; }

        static PatientBill LastBill;
        static bool HasLastBill = false;

        public static void CreateNewBill()
        {

            Console.Write("Enter BuildID: ");
            int BuildID = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient Name: ");
            string PatientName = Console.ReadLine();

            Console.Write("Does the patient have insurance? (yes/no): ");
            string insuranceInput = Console.ReadLine().ToLower();
            bool HasInsurance = insuranceInput == "yes";

            Console.Write("Enter Consultation Fee: ");
            decimal ConsultationFee = decimal.Parse(Console.ReadLine());
            if (ConsultationFee < 0)
            {
                Console.WriteLine("Consultation Fee must be greater than 0.");
            }

            Console.Write("Enter Lab Charges: ");
            decimal LabCharges = decimal.Parse(Console.ReadLine());
            if (LabCharges < 0)
            {
                Console.WriteLine("Lab Charges must be greater than 0.");
            }

            Console.Write("Enter Medicine Charges: ");
            decimal MedicineCharges = decimal.Parse(Console.ReadLine());
            if (MedicineCharges < 0)
            {
                Console.WriteLine("Medicine Charges must be greater than 0.");
            }

            PatientBill bill = new PatientBill
            {
                BuildID = BuildID,
                PatientName = PatientName,
                HasInsurance = HasInsurance,
                ConsultationFee = ConsultationFee,
                LabCharges = LabCharges,
                MedicineCharges = MedicineCharges
            };
            LastBill = bill;
            HasLastBill = true;

            bill.CalculateBill();

            Console.WriteLine("Bill created successfully.");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Gross Amount: {bill.GrossAmount}");
            Console.WriteLine($"Discount Amount: {bill.DiscountAmount}");
            Console.WriteLine($"Final Payable Amount: {bill.FinalPayable}");
            Console.WriteLine("--------------------------------------------");

        }

        public static void ViewLastBill()
        {
            if (HasLastBill)
            {
                Console.WriteLine($"BuildID: {LastBill.BuildID}");
                Console.WriteLine($"Patient Name: {LastBill.PatientName}");
                Console.WriteLine($"Has Insurance: {LastBill.HasInsurance}");
                Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee}");
                Console.WriteLine($"Lab Charges: {LastBill.LabCharges}");
                Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges}");
                Console.WriteLine($"Gross Amount: {LastBill.GrossAmount}");
            }
            else
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                Console.WriteLine("--------------------------------------------");

            }
        }

        public static void ClearLastBill()
        {
            LastBill = null;
            HasLastBill = false;
            Console.WriteLine("Last bill cleared.");
            Console.WriteLine("--------------------------------------------");
        }

        public void CalculateBill()
        {
            GrossAmount = ConsultationFee + LabCharges + MedicineCharges;

            if (HasInsurance)
            {
                DiscountAmount = GrossAmount * 0.10m; 
            }
            else
            {
                DiscountAmount = 0;
            }

            FinalPayable = Math.Round((GrossAmount - DiscountAmount),2);
        }
    }
}
