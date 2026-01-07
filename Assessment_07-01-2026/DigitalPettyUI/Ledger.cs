using System;
using System.Collections.Generic;

namespace DigitalPetty
{
    public class Ledger<T> where T : Transaction
    {
        internal List<T> transactions = new List<T>();

        public void AddEntry(T entry)
        {
            transactions.Add(entry);
        }

        public List<T> GetTransactionByDate(DateTime date)
        {
            List<T> result = new List<T>();
            foreach (T transaction in transactions)
            {
                if (transaction.Date.Date == date.Date)
                {
                    result.Add(transaction);
                }
            }
            return result;
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (T transaction in transactions)
            {
                total += transaction.Amount;
            }
            return total;
        }

    }
}