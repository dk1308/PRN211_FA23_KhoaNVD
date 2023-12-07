using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    public class CourseDAO
    {
        private CourseDAO() { }
        public static CourseDAO instance;
        public static readonly object instanceLock = new object();

        public static CourseDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CourseDAO();
                return instance;
            }
        }
        public void InsertCourse(Course course)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                myDBContext.Courses.Add(course);
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCourse(int courseId)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                Course course = myDBContext.Courses.SingleOrDefault(c => c.CourseId == courseId);
                if (course == null) throw new Exception("Course not found");
                myDBContext.Courses.Remove(course);
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCourse(Course course)
        {
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                myDBContext.Entry<Course>(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                myDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Course GetCourse(int courseId)
        {
            Course result = null;
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                result = myDBContext.Courses.SingleOrDefault(c => c.CourseId == courseId);
                if (result == null) throw new Exception("Course not found");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Course> GetAllCourses()
        {
            List<Course> result = null;
            try
            {
                MyDBContext myDBContext = new MyDBContext();
                result = myDBContext.Courses.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
