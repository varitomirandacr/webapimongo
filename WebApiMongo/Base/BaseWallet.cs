using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMongo.Contracts;

namespace WebApiMongo.Base
{
    // Template
    public abstract class BaseWallet : IExpenses
    {
        public BaseWallet()
        {
            // We work under Mountain Time
            _lastUpdated = DateTime.Today.AddHours(-2);
        }

        private DateTime _lastUpdated;
        public int Code { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated 
        { 
            get => _lastUpdated;
        }
        public decimal Income { get; set; }

        #region IExpenses implementation
        public string ExpenseName { get; set; }
        public int ExpenseId { get; set; }
        public decimal Amount { get; set; }
        public decimal Expense { get; set; }
        public decimal Calculate()
        {
            return (Amount - Expense);
        }

        #endregion
        //public bool TryGetExpenseSqrt(out double? decimalResult)
        //{
        //    decimalResult = null;

        //    if (Expense == 0)
        //    {
        //        return false;
        //    }

        //    Math.Sqrt(Expense);
        //}

        //public void
    }
}
