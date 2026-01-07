using System;
using System.Collections.Generic;

namespace DigitalPetty
{
    class Program
    {
        static void Main(string[] args)
        {
            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();
    
            incomeLedger.AddEntry(new IncomeTransaction(1, DateTime.Now, 500m, "Main Cash", "Salary"));
            expenseLedger.AddEntry(new ExpenseTransaction(1, DateTime.Now, 20m, "Expense", "Stationery"));
            expenseLedger.AddEntry(new ExpenseTransaction(2, DateTime.Now, 15m, "Expense", "Team Snacks"));

            Console.WriteLine("Income Transactions:");
            foreach (var transaction in incomeLedger.GetTransactionByDate(DateTime.Now))
            {
                Console.WriteLine(transaction.GetSummary());
            }

            Console.WriteLine("\nExpense Transactions:");
            foreach (var transaction in expenseLedger.GetTransactionByDate(DateTime.Now))
            {
                Console.WriteLine(transaction.GetSummary());
            }
            
            decimal totalIncome = incomeLedger.CalculateTotal();
            decimal totalExpenses = expenseLedger.CalculateTotal();

            Console.WriteLine("\n======Digital Petty Ledger Summary======");
            Console.WriteLine($"Total Income: {totalIncome:C}");
            Console.WriteLine($"Total Expenses: {totalExpenses:C}");
            Console.WriteLine($"Net Balance: {totalIncome - totalExpenses:C}");


            
        }
    }
}