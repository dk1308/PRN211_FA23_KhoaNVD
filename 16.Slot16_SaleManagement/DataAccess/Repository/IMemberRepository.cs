using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public void InsertMember(Member member);
        public void DeleteMember(int memberId);
        public void UpdateMember(Member member);
        public Member GetMember(int memberId);
        public Member GetMemberByEmail(string email);
        public Boolean Login(Member member);
        public IEnumerable<Member> GetAllMembers();
    }
}
