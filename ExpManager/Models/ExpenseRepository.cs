using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpManager.Models
{
    public class ExpenseRepository : ExpenseDal
    {
        private BddContext Db;

        public ExpenseRepository()
        {
            Db = new BddContext();
        }

        public List<Expense> GetAllExpenses(User user)
        {
            return Db.Expenses.Where(e=>e.User==user).ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        void ExpenseDal.CreateExpense(string name, double amount, DateTime date, User user)
        {
            Db.Expenses.Add(new Expense { Name = name, Amount = amount, Date = date, User = user });
            Db.SaveChanges();
        }
    }
}