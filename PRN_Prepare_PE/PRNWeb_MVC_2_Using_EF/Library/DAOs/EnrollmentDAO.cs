using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    public class EnrollmentDAO
    {
        private EnrollmentDAO() { }
        public static EnrollmentDAO instance;
        public static readonly object instanceLock = new object();

        public static EnrollmentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EnrollmentDAO();
                return instance;
            }
        }
        public void InsertEnrollment(Enrollment enrollment)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                Enrollment findE = myDBContext.Enrollments.SingleOrDefault(e => (e.CourseId == enrollment.CourseId && e.StudentId == enrollment.StudentId));
                if (findE != null)
                    throw new Exception("Enrollment already exist!");
                
                myDBContext.Enrollments.Add(enrollment);
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteEnrollment(int studentId, int courseId)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                Enrollment enrollment = myDBContext.Enrollments.SingleOrDefault(e => (e.CourseId == courseId && e.StudentId == studentId));
                if (enrollment == null) throw new Exception("Enrollment not found");
                myDBContext.Enrollments.Remove(enrollment);
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateEnrollment(Enrollment enrollment)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                myDBContext.Entry<Enrollment>(enrollment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Enrollment GetEnrollment(int studentId, int courseId)
        {
            Enrollment result = null;
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                result = myDBContext.Enrollments.SingleOrDefault(e => (e.CourseId == courseId && e.StudentId == studentId));
                if (result == null) throw new Exception("Enrollment not found");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Enrollment> GetAllEnrollment()
        {
            List<Enrollment> result = null;
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                result = myDBContext.Enrollments.Include(e => e.Course).Include(e => e.Student).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
