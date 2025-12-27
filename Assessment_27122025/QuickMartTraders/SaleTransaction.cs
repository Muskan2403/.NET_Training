using System;

namespace QuickMartTraders{
    public class SaleTransaction
    {
        public string InvoiceNo { get; set; }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal SellingAmount { get; set; }
        public string ProfitOrLossStatus { get; set; }
        public decimal ProfitOrLossAmount { get; set; }
        public decimal ProfitMarginPercentage { get; set; }

        public static SaleTransaction LastTransaction { get; set; }
        public static bool HasLastTransaction { get; set; } = false;
        public SaleTransaction(string invoiceNo, string customerName, string itemName, int quantity, decimal purchaseAmount, decimal sellingAmount)
        {
            InvoiceNo = invoiceNo;
            CustomerName = customerName;
            ItemName = itemName;
            Quantity = quantity;
            PurchaseAmount = purchaseAmount;
            SellingAmount = sellingAmount;

            CalculateProfitOrLoss();
        }

        public void CalculateProfitOrLoss()
        {

            if (SellingAmount > PurchaseAmount)
            {
                ProfitOrLossStatus = "Profit";
                ProfitOrLossAmount = SellingAmount - PurchaseAmount;
            }
            else if (SellingAmount < PurchaseAmount)
            {
                ProfitOrLossStatus = "Loss";
                ProfitOrLossAmount = PurchaseAmount - SellingAmount;
            }
            else
            {
                ProfitOrLossStatus = "Break-Even";
                ProfitOrLossAmount = 0;
            }

            if (PurchaseAmount != 0)
            {
                ProfitMarginPercentage = Math.Round(((ProfitOrLossAmount / PurchaseAmount) * 100),2);
            }
            else
            {
                ProfitMarginPercentage = 0;
            }
        }
        public static void CreateNewTransaction()
        {
            Console.Write($"Enter Invoice No:  ");
                string invoiceNo = Console.ReadLine();
                if (invoiceNo == null)
                {
                    Console.WriteLine("Invoice No cannot be empty. Please try again.");
                }

                Console.Write("Enter Customer Name: ");
                string customerName = Console.ReadLine();

                Console.Write("Enter Item Name: ");
                string itemName = Console.ReadLine();

                Console.Write("Enter Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity <= 0)
                {
                    Console.WriteLine("Quantity must be greater than zero.");
                }

                Console.Write("Enter Purchase Amount: ");
                decimal purchaseAmount = Convert.ToDecimal(Console.ReadLine());
                if (purchaseAmount < 0)
                {
                    Console.WriteLine("Purchase Amount cannot be negative.");
                }

                Console.Write("Enter Selling Amount: ");
                decimal sellingAmount = Convert.ToDecimal(Console.ReadLine());

                SaleTransaction transaction = new SaleTransaction(invoiceNo, customerName, itemName, quantity, purchaseAmount, sellingAmount);

                LastTransaction = transaction;
                HasLastTransaction = true;

                Console.WriteLine("Transaction Saved Successfully.");

                Console.WriteLine($"Status: {transaction.ProfitOrLossStatus}");
                Console.WriteLine($"Profit/Loss Amount: {transaction.ProfitOrLossAmount}");
                Console.WriteLine($"Profit Margin(%): {transaction.ProfitMarginPercentage}");
                Console.WriteLine("------------------------------------------------------");
        }

        public static void ViewLastTransaction()
        {
            if (HasLastTransaction)
            {
                LastTransaction.PrintTransactionDetails();
            }
            else
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                Console.WriteLine("------------------------------------------------------");
                
            }
        }

        public static void RecomputeAndPrintLastTransaction()
        {
            if (HasLastTransaction)
            {
                LastTransaction.CalculateProfitOrLoss();
                LastTransaction.PrintTransactionDetails();
            }
            else
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                Console.WriteLine("------------------------------------------------------");

            }
        }
        public void PrintTransactionDetails()
        {
            Console.WriteLine("----- Last Transaction -----");
            Console.WriteLine($"Invoice No: {InvoiceNo}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Item Name: {ItemName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Purchase Amount: {PurchaseAmount}");
            Console.WriteLine($"Selling Amount: {SellingAmount}");
            Console.WriteLine($"Profit/Loss Status: {ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin Percentage: {ProfitMarginPercentage}%");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}