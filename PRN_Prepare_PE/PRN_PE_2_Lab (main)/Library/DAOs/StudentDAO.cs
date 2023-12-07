using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    public class StudentDAO
    {
        private StudentDAO() { }
        public static StudentDAO instance;
        public static readonly object instanceLock = new object();

        public static StudentDAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new StudentDAO();
                return instance;
            }
        }

        public void InsertStudent(Student student)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                myDBContext.Students.Add(student);
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteStudent(int studentId)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                Student student = myDBContext.Students.SingleOrDefault(s => s.StudentId == studentId);
                if (student == null) throw new Exception("Student not found");
                myDBContext.Students.Remove(student);
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateStudent(Student student)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                myDBContext.Entry<Student>(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Student GetStudent(int studentId)
        {
            Student result = null;
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                result = myDBContext.Students.SingleOrDefault(s => s.StudentId == studentId);
                if (result == null) throw new Exception("Student not found");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> result = null;
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                result = myDBContext.Students.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
