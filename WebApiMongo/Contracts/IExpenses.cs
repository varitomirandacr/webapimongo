using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMongo.Contracts
{
    public interface IExpenses
    {
        int ExpenseId { get; set; }
        string ExpenseName { get; set; }
        decimal Amount { get; set; }
        decimal Expense { get; set; }
        decimal Calculate();
    }
}
