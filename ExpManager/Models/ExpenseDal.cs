using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpManager.Models
{
    interface ExpenseDal : IDisposable
    {
        void CreateExpense(string name, double amount, DateTime date, User user);
        List<Expense> GetAllExpenses(User user);
    }
}
