using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpManager.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}