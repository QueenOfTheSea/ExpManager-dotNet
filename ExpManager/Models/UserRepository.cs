using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpManager.Models
{
    public class UserRepository : UserDal
    {
        private BddContext Db;

        public UserRepository()
        {
            Db = new BddContext();
        }

        public void CreateUser(string login, string password)
        {
            Db.users.Add(new User { Login=login, Password=password});
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}