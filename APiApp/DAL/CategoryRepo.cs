using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CategoryRepo : IRepo<Category>
    {
        NPEntities db;
        public CategoryRepo(NPEntities db)
        {
            this.db = db;
        }

        public void Add(Category e)
        {
            db.Categories.Add(e);
            db.SaveChanges();
        }

        public void Delete(Category e)
        {
            var c = db.Categories.FirstOrDefault(en => en.Id == e.Id);
            db.Categories.Remove(c);
            db.SaveChanges();
        }

        public void Edit(Category e)
        {
            var c = db.Categories.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(c).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

    }
}
