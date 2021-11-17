using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class NewsRepo : IRepo<News, int, string, DateTime>
    {
        NPEntities db;
        public NewsRepo(NPEntities db)
        {
            this.db = db;
        }


        public void Add(News e)
        {
            db.News.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var n = db.News.FirstOrDefault(e => e.Id == id);
            db.News.Remove(n);
            db.SaveChanges();
        }

        public void Edit(News e)
        {
            var n = db.News.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }
        public News Get(int id)
        {
            return db.News.FirstOrDefault(e => e.Id == id);
        }

        public News Get(string category)
        {
            var c = db.Categories.FirstOrDefault(e => e.Type == category);
            return db.News.FirstOrDefault(e => e.CategoryId == c.Id);
        }

        public News Get(string category, DateTime date)
        {
            var c = db.Categories.FirstOrDefault(e => e.Type == category);
            return db.News.FirstOrDefault(e => e.CategoryId == c.Id
                                            && e.Date == date);
        }
    }
}
