using System;

namespace DigitalPetty{

    public class ExpenseTransaction : Transaction, IReportable
    {
        public string Category { get; set; }

        public ExpenseTransaction(
            int id,
            DateTime date,
            decimal amount,
            string description,
            string category
        ) : base(id, date, amount, description)
        {
            Category = category;
        }

        public override string GetSummary()
        {
            return $"Expense #{Id}: {Date:yyyy-MM-dd} - {Amount:C} - {Category} - {Description}";
        }
    }
}
