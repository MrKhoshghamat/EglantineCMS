using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LoginRepository : ILoginRepository
    {
        private EglantineCMSContext db;

        public LoginRepository(EglantineCMSContext context)
        {
            db = context;
        }
        public bool IsExistUser(string username, string password)
        {
            return db.AdminLogins.Any(u => u.UserName == username && u.Password == password);
        }
    }
}
