using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CommentRepo : IRepo<Comment, int>
    {
        NPEntities db;
        public CommentRepo(NPEntities db)
        {
            this.db = db;
        }


        public void Add(Comment e)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment e)
        {
            throw new NotImplementedException();
        }

        public void Edit(Comment e)
        {
            throw new NotImplementedException();
        }

        public List<Comment> Get()
        {
            return db.Comments.ToList();
        }

        public List<Comment> Get(int id)
        {
            var entity = (from e in db.Comments
                          where e.NewsId == id
                          select e).ToList();
            return entity;
        }
    }
}
