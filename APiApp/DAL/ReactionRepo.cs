using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ReactionRepo : IRepo<Reaction, int>
    {
        NPEntities db;
        public ReactionRepo(NPEntities db)
        {
            this.db = db;
        }



        public void Add(Reaction e)
        {
            throw new NotImplementedException();
        }

        public void Delete(Reaction e)
        {
            throw new NotImplementedException();
        }

        public void Edit(Reaction e)
        {
            throw new NotImplementedException();
        }

        public List<Reaction> Get()
        {
            return db.Reactions.ToList();
        }

        public List<Reaction> Get(int id)
        {
            var entity = (from e in db.Reactions
                          where e.NewsId == id
                          select e).ToList();
            return entity;
        }
    }
}
