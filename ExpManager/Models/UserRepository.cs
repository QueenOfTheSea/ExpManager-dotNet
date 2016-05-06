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
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}