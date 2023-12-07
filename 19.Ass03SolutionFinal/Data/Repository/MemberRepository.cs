using Object;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberId)
        {
            try
            {
                Member member = MemberDAO.Instance.GetMember(memberId);
                if (member == null) throw new Exception("Not found member!");
                MemberDAO.Instance.DeleteMember(memberId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return MemberDAO.Instance.GetAll();
        }

        public Member GetMember(int memberId)
        {
            Member res = null;
            try
            {
                res = MemberDAO.Instance.GetMember(memberId);
                if (res == null) throw new Exception("Not found member!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }

        public Member GetMemberByEmail(string email)
        {
            Member res = null;
            try
            {
                res = MemberDAO.Instance.GetMemberByEmail(email);
                if (res == null) throw new Exception("Not found member!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }

        public void InsertMember(Member member)
        {
            try
            {
                MemberDAO.Instance.InsertMember(member);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Member Login(Member member)
        {
            Member res = null;
            try
            {
                res = MemberDAO.Instance.GetMemberByEmail(member.Email);
                if (res == null) throw new Exception("Not found member!");
                if (!res.Password.Equals(member.Password)) throw new Exception("Incorrect username or password!");
                return res;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public void UpdateMember(Member member)
        {
            try
            {
                Member findMember = MemberDAO.Instance.GetMember(member.MemberId);
                if (findMember == null) throw new Exception("Not found member!");
                MemberDAO.Instance.UpdateMember(member);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

/*        bool IMemberRepository.Login(Member member)
        {
            Member res = null;
            try
            {
                res = MemberDAO.Instance.GetMemberByEmail(member.Email);
                if (res == null) throw new Exception("Not found member!");
                if (!res.Password.Equals(member.Password)) throw new Exception("Incorrect username or password!");
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
    }
}
