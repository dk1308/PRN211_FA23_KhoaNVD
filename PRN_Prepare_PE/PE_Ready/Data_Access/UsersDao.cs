using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class UsersDao
    {
        private PeDB stock = new PeDB();
        private static UsersDao instance = null;
        private static readonly object instanceLock = new object();
        public UsersDao() { }
        public static UsersDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UsersDao();
                    }
                    return instance;
                }
            }
        }

        public List<Users> GetAllUsers()
        {
            List<Users> Userss;
            try
            {
                using PeDB stock = new PeDB();
                Userss = stock.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Userss;
        }

        public void InsertUsers(Users Users)
        {
            try
            {
                using PeDB stock = new PeDB();
                stock.Users.Add(Users);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateUsers(Users Users)
        {
            try
            {
                using PeDB stock = new PeDB();
                stock.Entry<Users>(Users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteUsers(Users Users)
        {
            try
            {
                using PeDB stock = new PeDB();
                var p = stock.Users.SingleOrDefault(c => c.UserId == Users.UserId);
                stock.Users.Remove(p);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Users findUsersById(int Usersid)
        {
            try
            {
                using PeDB stock = new PeDB();
                var p = stock.Users.SingleOrDefault(c => c.UserId == Usersid);
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Users findUsersByUserName(string username)
        {
            try
            {
                using PeDB stock = new PeDB();
                var p = stock.Users.SingleOrDefault(c => c.UserName.Equals(username));
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UserLogin(string username, string password)
        {
           var result = stock.Users.SingleOrDefault(x=> x.UserName.Equals(username)&& x.Password.Equals(password));
            if (result == null) return false;
            else return true;
        }
    }
}
