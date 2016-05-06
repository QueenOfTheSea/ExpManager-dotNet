using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExpManager.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<User> users { get; set; }
    }
}