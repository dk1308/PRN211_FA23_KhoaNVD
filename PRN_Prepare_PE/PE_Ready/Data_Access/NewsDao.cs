using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class NewsDao
    {

        private static NewsDao instance = null;
        private static readonly object instanceLock = new object();
        public NewsDao() { }
        public static NewsDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new NewsDao();
                    }
                    return instance;
                }
            }
        }

        public List<News> GetAllNews()
        {
            List<News> Newss;
            try
            {
                using PeDB stock = new PeDB();
                Newss = stock.News.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Newss;
        }

        public void InsertNews(News News)
        {
            try
            {
                using PeDB stock = new PeDB();
                stock.News.Add(News);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateNews(News News)
        {
            try
            {
                using PeDB stock = new PeDB();
                stock.Entry<News>(News).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteNews(News News)
        {
            try
            {
                using PeDB stock = new PeDB();
                var p = stock.News.SingleOrDefault(c => c.Id == News.Id);
                stock.News.Remove(p);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public News findNewsById(int Newsid)
        {
            try
            {
                using PeDB stock = new PeDB();
                var p = stock.News.SingleOrDefault(c => c.Id == Newsid);
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
