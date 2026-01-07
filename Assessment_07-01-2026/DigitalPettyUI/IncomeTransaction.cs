using System;

namespace DigitalPetty{

    class IncomeTransaction: Transaction
    {

        public string Source { get; set; }

        public IncomeTransaction(int id, DateTime date, decimal amount, string description, string source)
            : base(id, date, amount, description)
        {
            Source = source;
        }
        public override string GetSummary()
        {
            return $"Income #{Id}: {Date:yyyy-MM-dd} - {Amount:C} - {Source} - {Description}";
        }
    }
}
