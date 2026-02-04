using System;

namespace Ledger{

    public class Khata
    {
        private Dictionary<string, int> record;

        public Khata(Dictionary<string, int> record)
        {
            this.record = record;
        }

        public int getTotal()
        {
            int total = 0;
            foreach (var amount in record.Values)
            {
                total += amount;
            }
            return total;
        }

        public int getRepeatAmount()
        {
            Dictionary<int, int> amountCount = new Dictionary<int, int>();
            foreach (var amount in record.Values)
            {
                if (amountCount.ContainsKey(amount))
                {
                    amountCount[amount]++;
                }
                else
                {
                    amountCount[amount] = 1;
                }
            }
            return amountCount.Values.Count(count => count > 1);
        }

        public void AddItem(string itemName, int amount)
        {
            if(!record.ContainsKey(itemName))
            {
                record[itemName] = amount;
            }
            else
            {
                Console.WriteLine("Item already exists in the record.");
            }
            
        }

    }
}