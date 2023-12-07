using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess.DAO
{
    public class MemberDAO
    {
        public static MemberDAO instance;
        public static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance {  
            
            get {
                lock (instanceLock)
                {
                    if (instance == null)
                        instance = new MemberDAO();
                    return instance;
                }
            }
            
        }

        public void InsertMember(Member member)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.Members.Add(member);
                sm.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.StackTrace); 
            }
        }
        public void DeleteMember(int memberId)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.Members.Remove(sm.Members.SingleOrDefault(m => m.MemberId == memberId));
                sm.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Member GetMember(int memberId)
        {
            Member res = null;
            try
            {
                using SmdbContext sm = new SmdbContext();
                res = sm.Members.SingleOrDefault(m => m.MemberId == memberId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }
        public void UpdateMember(Member member)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                sm.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public Member GetMemberByEmail(string email)
        {
            Member res = null;
            try
            {
                using SmdbContext sm = new SmdbContext();
                res = sm.Members.SingleOrDefault(m => m.Email.Equals(email));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }
        public List<Member> GetAll()
        {
            SmdbContext saleManagementDbContext = new SmdbContext();
            return saleManagementDbContext.Members.ToList();
        }
    }
}
