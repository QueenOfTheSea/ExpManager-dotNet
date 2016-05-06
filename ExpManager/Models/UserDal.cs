using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpManager.Models
{
    interface UserDal : IDisposable
    {
        void CreateUser(string login, string password);
    }
}
